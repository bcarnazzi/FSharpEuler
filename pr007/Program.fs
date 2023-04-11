module pr007

let solve n = eulerlib.primeSeq |> Seq.item n

[<EntryPoint>]
let main _ =
    printfn $"{solve 10_000}"
    0
