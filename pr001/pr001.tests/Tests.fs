module Tests

open System
open Xunit

[<Fact>]
let ``Problem Sample`` () =
    let expected = 23
    let actual = pr001.solve 10
    Assert.Equal(actual, expected)
