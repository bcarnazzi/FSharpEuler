module Tests

open System
open Xunit

[<Fact>]
let ``u0`` () =
    let expected = 1 |> bigint
    let actual = eulerlib.fibSeq 1I 2I |> Seq.head
    Assert.Equal(expected, actual)

[<Fact>]
let ``u1`` () =
    let expected = 2 |> bigint
    let actual = eulerlib.fibSeq 1I 2I |> Seq.item 1
    Assert.Equal(expected, actual)

[<Fact>]
let ``u2`` () =
    let expected = 3 |> bigint
    let actual = eulerlib.fibSeq 1I 2I |> Seq.item 2
    Assert.Equal(expected, actual)

[<Fact>]
let ``u3`` () =
    let expected = 5 |> bigint
    let actual = eulerlib.fibSeq 1I 2I |> Seq.item 3
    Assert.Equal(expected, actual)

[<Fact>]
let ``u4`` () =
    let expected = 8 |> bigint
    let actual = eulerlib.fibSeq 1I 2I |> Seq.item 4
    Assert.Equal(expected, actual)

[<Fact>]
let ``u5`` () =
    let expected = 13 |> bigint
    let actual = eulerlib.fibSeq 1I 2I |> Seq.item 5
    Assert.Equal(expected, actual)

[<Fact>]
let ``u6`` () =
    let expected = 21 |> bigint
    let actual = eulerlib.fibSeq 1I 2I |> Seq.item 6
    Assert.Equal(expected, actual)

[<Fact>]
let ``u7`` () =
    let expected = 34 |> bigint
    let actual = eulerlib.fibSeq 1I 2I |> Seq.item 7
    Assert.Equal(expected, actual)

[<Fact>]
let ``u8`` () =
    let expected = 55 |> bigint
    let actual = eulerlib.fibSeq 1I 2I |> Seq.item 8
    Assert.Equal(expected, actual)

[<Fact>]
let ``u9`` () =
    let expected = 89 |> bigint
    let actual = eulerlib.fibSeq 1I 2I |> Seq.item 9
    Assert.Equal(expected, actual)

[<Fact>]
let ``p0`` () =
    let expected = 2 |> bigint
    let actual = eulerlib.primeSeq |> Seq.item 0
    Assert.Equal(expected, actual)

[<Fact>]
let ``p1`` () =
    let expected = 3 |> bigint
    let actual = eulerlib.primeSeq |> Seq.item 1
    Assert.Equal(expected, actual)

[<Fact>]
let ``p2`` () =
    let expected = 5 |> bigint
    let actual = eulerlib.primeSeq |> Seq.item 2
    Assert.Equal(expected, actual)

[<Fact>]
let ``p3`` () =
    let expected = 7 |> bigint
    let actual = eulerlib.primeSeq |> Seq.item 3
    Assert.Equal(expected, actual)

[<Fact>]
let ``p4`` () =
    let expected = 11 |> bigint
    let actual = eulerlib.primeSeq |> Seq.item 4
    Assert.Equal(expected, actual)

[<Fact>]
let ``p5`` () =
    let expected = 13 |> bigint
    let actual = eulerlib.primeSeq |> Seq.item 5
    Assert.Equal(expected, actual)

[<Fact>]
let ``p6`` () =
    let expected = 17 |> bigint
    let actual = eulerlib.primeSeq |> Seq.item 6
    Assert.Equal(expected, actual)

[<Fact>]
let ``p7`` () =
    let expected = 19 |> bigint
    let actual = eulerlib.primeSeq |> Seq.item 7
    Assert.Equal(expected, actual)

[<Fact>]
let ``p8`` () =
    let expected = 23 |> bigint
    let actual = eulerlib.primeSeq |> Seq.item 8
    Assert.Equal(expected, actual)

[<Fact>]
let ``p9`` () =
    let expected = 29 |> bigint
    let actual = eulerlib.primeSeq |> Seq.item 9
    Assert.Equal(expected, actual)

[<Fact>]
let ``pf0`` () =
    let expected = [ 29I; 13I; 7I; 5I ]
    let actual = eulerlib.primeFactors 13195I
    Assert.True(List.forall2 (fun x y -> x = y) expected actual)
