open System
open System.IO
open CompanyData
open ClosedXML.SimpleSheets

let client = CompanyDataGraphqlClient("http://localhost:5000/graphql")

[<EntryPoint>]
let main argv =
    let data = client.GetAllCompanies()
    match data with
    | Ok data ->
        let companies = data.allCompanies

        let companiesExcel = Excel.createFrom(companies, [
            companies
                .excelField(fun company -> company.id)
                .header("ID")
                .adjustToContents()

            companies
                .excelField(fun company -> company.name)
                .header("Name")
                .adjustToContents()

            companies
                .excelField(fun company -> company.industry)
                .header("Industry")
                .adjustToContents()
        ])

        File.WriteAllBytes("Companies.xlsx", companiesExcel)

    | Error serverErrors ->
        for error in serverErrors do
            Console.WriteLine(error.message)

    0