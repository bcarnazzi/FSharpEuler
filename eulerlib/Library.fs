module eulerlib

#nowarn "40"

let rec fibSeq (u0: bigint) (u1: bigint) =
    seq {
        yield u0
        yield! fibSeq u1 (u0 + u1)
    }

let rec primeSeq: bigint seq =
    let rec bigOddsFrom (n: bigint) =
        seq {
            yield n
            yield! bigOddsFrom (n + 2I)
        }

    seq {
        yield 2I
        yield! bigOddsFrom 3I |> Seq.filter isPrime
    }
    |> Seq.cache

and isPrime (n: bigint) : bool =
    primeSeq
    |> Seq.takeWhile (fun p -> p * p <= n)
    |> Seq.exists (fun p -> n % p = 0I)
    |> not

let primeFactors (n: bigint) : bigint list =
    let mutable pfs = []
    let mutable pidx = 0
    let mutable cp = primeSeq |> Seq.item pidx
    let mutable cn = n

    while cn > 1I do
        if cn % cp = 0I then
            pfs <- cp :: pfs
            cn <- cn / cp
        else
            pidx <- pidx + 1
            cp <- primeSeq |> Seq.item pidx

    pfs

let reverseString (s: string) =
    s.ToCharArray() |> Array.rev |> System.String

let isPalindromic (n: bigint) : bool =
    let s = n.ToString()
    s = reverseString s