[<RequireQualifiedAccess>]
module rec CompanyData.GetAllCompanies

type Employee =
    { id: Option<string>
      firstName: Option<string>
      lastName: Option<string>
      status: Status
      address: Option<string> }

type Company =
    { id: Option<string>
      name: string
      industry: Option<string>
      employees: list<Employee> }

type Query = { allCompanies: list<Company> }
