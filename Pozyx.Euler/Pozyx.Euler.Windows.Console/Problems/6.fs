module _6

// https://projecteuler.net/problem=6

let n = 100

let numbers = {1..n}

let result = 
    (pown (numbers |> Seq.sum) 2)
    - (numbers |> Seq.map (fun x -> pown x 2) |> Seq.sum)
