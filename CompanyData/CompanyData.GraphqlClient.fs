namespace CompanyData

open Newtonsoft.Json
open Newtonsoft.Json.Linq
open Fable.Remoting.Json
open System
open System.Net.Http
open System.Net.Http.Json
open System.Text
open System.IO


type GraphqlInput<'T> = { query: string; variables: Option<'T> }
type GraphqlSuccessResponse<'T> = { data: 'T }
type GraphqlErrorResponse = { errors: ErrorType list }

type CompanyDataGraphqlClient(url: string, httpClient: HttpClient) =
    let fableJsonConverter = FableJsonConverter() :> JsonConverter
    let settings = JsonSerializerSettings(DateParseHandling=DateParseHandling.None, Converters = [| fableJsonConverter |])
    let serializer = JsonSerializer.Create(settings)

    new(url: string) = CompanyDataGraphqlClient(url, new HttpClient())
    new(httpClient: HttpClient) =
        if httpClient.BaseAddress <> null then
            CompanyDataGraphqlClient(httpClient.BaseAddress.OriginalString, httpClient)
        else
            raise <| System.ArgumentNullException("BaseAddress of the HttpClient cannot be null for the constructor that only accepts a HttpClient")
            CompanyDataGraphqlClient(String.Empty, httpClient)

    
    member _.CompanyByEmployeeIdAsync(input: CompanyByEmployeeId.InputVariables) =
        async {
            let query = """
                query ($id:ID!) {
    employee(id: $id) {
        company {
            id
            name
            industry
        }
    }
}
            """

            
            let inputJson = JsonConvert.SerializeObject({ query = query; variables = Some input }, settings)
            let! response =
                httpClient.PostAsync(url, new StringContent(inputJson, Encoding.UTF8, "application/json"))
                |> Async.AwaitTask
    
            let! responseContent = Async.AwaitTask(response.Content.ReadAsStreamAsync())
            use sr = new StreamReader(responseContent)
            use tr = new JsonTextReader(sr)
            let responseJson = serializer.Deserialize<JObject>(tr)

            match response.IsSuccessStatusCode with
            | true ->
                let errorsReturned =
                    responseJson.ContainsKey "errors"
                    && responseJson.["errors"].Type = JTokenType.Array
                    && responseJson.["errors"].HasValues

                if errorsReturned then
                    let response = responseJson.ToObject<GraphqlErrorResponse>(JsonSerializer.Create(settings))
                    return Error response.errors
                else
                    let response = responseJson.ToObject<GraphqlSuccessResponse<CompanyByEmployeeId.Query>>(JsonSerializer.Create(settings))
                    return Ok response.data

            | errorStatus ->
                let response = responseJson.ToObject<GraphqlErrorResponse>(JsonSerializer.Create(settings))
                return Error response.errors
        }

    member this.CompanyByEmployeeId(input: CompanyByEmployeeId.InputVariables) = Async.RunSynchronously(this.CompanyByEmployeeIdAsync input)


    member _.GetAllCompaniesAsync() =
        async {
            let query = """
                query GetAllCompanies {
    allCompanies {
        id
        name
        industry
        employees {
            id
            firstName
            lastName
            status
            address
        }
    }
}
            """

            
            let inputJson = JsonConvert.SerializeObject({ query = query; variables = None }, settings)
            let! response =
                httpClient.PostAsync(url, new StringContent(inputJson, Encoding.UTF8, "application/json"))
                |> Async.AwaitTask
    
            let! responseContent = Async.AwaitTask(response.Content.ReadAsStreamAsync())
            use sr = new StreamReader(responseContent)
            use tr = new JsonTextReader(sr)
            let responseJson = serializer.Deserialize<JObject>(tr)

            match response.IsSuccessStatusCode with
            | true ->
                let errorsReturned =
                    responseJson.ContainsKey "errors"
                    && responseJson.["errors"].Type = JTokenType.Array
                    && responseJson.["errors"].HasValues

                if errorsReturned then
                    let response = responseJson.ToObject<GraphqlErrorResponse>(JsonSerializer.Create(settings))
                    return Error response.errors
                else
                    let response = responseJson.ToObject<GraphqlSuccessResponse<GetAllCompanies.Query>>(JsonSerializer.Create(settings))
                    return Ok response.data

            | errorStatus ->
                let response = responseJson.ToObject<GraphqlErrorResponse>(JsonSerializer.Create(settings))
                return Error response.errors
        }

    member this.GetAllCompanies() = Async.RunSynchronously(this.GetAllCompaniesAsync())
