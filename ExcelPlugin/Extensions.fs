namespace CensoExcel

[<AutoOpen>]
module Extensions = 
    type Option<'t> with 
        member self.map f = Option.map f self
        member self.bind f = Option.bind f self
    
    type List<'t> with 
        member self.map f = List.map f self
        member self.choose f = List.choose f self 
        member self.filter f = List.filter f self 
        member self.isEmpty() = List.isEmpty self
