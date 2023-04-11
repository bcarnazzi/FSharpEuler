module pr003

let solve = eulerlib.primeFactors >> Seq.max

[<EntryPoint>]
let main _ =
    printfn $"{solve 600_851_475_143I}"
    0
