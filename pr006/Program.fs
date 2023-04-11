module pr006

let solve (n: uint64) : uint64 =
    let a = seq { 1UL .. n } |> Seq.map (fun n -> n * n) |> Seq.sum
    let b = seq { 1UL .. n } |> Seq.sum |> (fun x -> x * x)
    b - a

[<EntryPoint>]
let main _ =
    printfn $"{solve 100UL}"
    0
