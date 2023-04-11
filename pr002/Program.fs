module pr002

let solve (m: bigint) =
    eulerlib.fibSeq 1I 2I
    |> Seq.takeWhile (fun n -> n < m)
    |> Seq.filter (fun n -> n % 2I = 1I)
    |> Seq.sum

[<EntryPoint>]
let main _ =
    printfn $"{solve 4_000_000I}"
    0
