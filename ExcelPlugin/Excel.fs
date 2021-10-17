namespace ExcelPlugin

open CompanyData

[<AutoOpen>]
module Util = 
    let client = CompanyDataGraphqlClient("http://localhost:5000/graphql")

type Excel() =
    static member Hello(name: string) : string = sprintf "Hello %s" name

    static member Matrix(n: int) = array2D [
        for i in 1 .. n do 
        [ for j in 1 .. n do box (i * j) ]
    ]

    static member Companies() = 
        match client.GetAllCompanies() with 
        | Ok response -> 
            let companies = response.allCompanies
            Table.from companies [
                "ID" => companies.cell (fun company -> company.id)
                "Name" => companies.cell (fun company -> company.name)
                "Industry" => companies.cell (fun company -> company.industry)
            ]
        | Error serverErrors -> 
            Table.from serverErrors [
                "Message" => serverErrors.cell (fun error -> error.message)
            ]

    static member SearchEmployees(query: string) = 
        match client.GetAllCompanies() with 
        | Ok response -> 
            let employees = 
                response.allCompanies
                |> List.collect (fun company -> company.employees)
                |> List.filter (fun employee -> 
                    let firstName = defaultArg employee.firstName ""
                    let lastName = defaultArg employee.lastName ""
                    firstName.Contains query || lastName.Contains query
                )
            
            Table.from employees [
                employees.cell (fun employee -> employee.id)
                employees.cell (fun employee -> employee.firstName)
                employees.cell (fun employee -> employee.lastName)
                employees.cell (fun employee -> employee.address)
                employees.cell (fun employee -> employee.status.ToString())
            ]

        | Error serverErrors -> 
            Table.from serverErrors [
                "Message" => serverErrors.cell (fun error -> error.message)
            ]