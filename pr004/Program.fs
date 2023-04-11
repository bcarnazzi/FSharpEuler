module pr004

let solve =
    seq {
        for a in 100..999 do
            yield! seq { for b in a..999 -> a * b |> bigint }
    }
    |> Seq.filter eulerlib.isPalindromic
    |> Seq.max

[<EntryPoint>]
let main _ =
    printfn $"{solve}"
    0
