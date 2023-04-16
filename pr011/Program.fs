module pr011

let product (numbers: bigint[]) : bigint = Array.fold (*) 1I numbers

let inRange (x: int, y: int) : bool = x >= 0 && x < 20 && y >= 0 && y < 20

let directions = [| (0, 1); (1, 0); (1, 1); (1, -1) |]

let solve (grid: bigint[][]) : bigint =
    let mutable maxProduct = 0I

    for i in 0..19 do
        for j in 0..19 do
            for (dx, dy) in directions do
                let indices = [| for k in 0..3 -> (i + k * dx, j + k * dy) |]

                if Array.forall inRange indices then
                    let values = [| for (x, y) in indices -> grid[x][y] |]
                    maxProduct <- max maxProduct (product values)

    maxProduct

[<EntryPoint>]
let main args =
    printfn $"{args[0] |> eulerlib.readDataAsArray |> solve}"
    0
