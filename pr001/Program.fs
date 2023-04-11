module pr001

let solve x =
    seq { 3 .. x - 1 } |> Seq.filter (fun n -> n % 3 = 0 || n % 5 = 0) |> Seq.sum

[<EntryPoint>]
let main _ =
    printfn $"%d{solve 1000}"
    0
