module pr005

let solve (n : bigint ) : bigint =
    seq { 1I .. n } |> Seq.fold (fun acc elem -> eulerlib.lcm acc elem) 1I

[<EntryPoint>]
let main _ =
    printfn $"{solve 20I}"
    0