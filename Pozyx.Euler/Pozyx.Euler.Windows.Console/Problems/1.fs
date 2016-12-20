module _1

// https://projecteuler.net/problem=1
// my first ever F# program

let upperBound = 1000
let numbers = [1..(upperBound - 1)]
let numbers_div_by_x x = numbers |> List.filter (fun n -> n % x = 0) |> Set.ofList 
let numbers_div_by_3 = numbers_div_by_x 3
let numbers_div_by_5 = numbers_div_by_x 5
let numbers_div_by_3_and_5 = Set.union numbers_div_by_3 numbers_div_by_5
let sum = Set.toList numbers_div_by_3_and_5 |> List.sum