module pr009

let isPythagoreanTriplet a b c =
    a < b && b < c && a * a + b * b = c * c

let solve (n : uint64) =
    seq {
        for a in 1UL .. n do
            for b in a .. n do
                let c = n - a - b
                if a + b < n && isPythagoreanTriplet a b c then
                    yield a * b * c
                
    } |> Seq.max

[<EntryPoint>]
let main _ =
    printfn $"{solve 1_000UL}"
    0