[<RequireQualifiedAccess>]
module rec CompanyData.CompanyByEmployeeId

type InputVariables = { id: string }

type Company =
    { id: Option<string>
      name: string
      industry: Option<string> }

type Employee = { company: Company }
type Query = { employee: Option<Employee> }
