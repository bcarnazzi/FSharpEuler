module pr010

let solve n =
    eulerlib.primeSeq |> Seq.takeWhile ((>) n) |> Seq.sum

[<EntryPoint>]
let main _ =
    printfn $"{solve 2_000_000I}"
    0
