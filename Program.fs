// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let server = Prometheus.Client.MetricServer.MetricServer(9090)
    server.Start()
    printfn "Hello World from F#!"
    0 // return an integer exit code
