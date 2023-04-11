module pr005

let solve (n: bigint) : bigint =
    seq { 1I .. n } |> Seq.fold eulerlib.lcm 1I

[<EntryPoint>]
let main _ =
    printfn $"{solve 20I}"
    0
