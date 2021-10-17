namespace CensoExcel

open System
open System.Net.Http
open System.Net

[<AutoOpen>]
module Util =

    ServicePointManager.SecurityProtocol <- SecurityProtocolType.Tls11 ||| SecurityProtocolType.Tls12;

    let prependHttps (url: string) = 
        if not (url.StartsWith "https://" || url.StartsWith "http://")
        then "https://" + url 
        else url

    let httpClient = new HttpClient()

type Excel() =
    static member Hello(name: string) = sprintf "Hello %s" name