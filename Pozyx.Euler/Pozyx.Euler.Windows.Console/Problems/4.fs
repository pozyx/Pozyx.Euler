module _4

// https://projecteuler.net/problem=4

let digits = 3

let decompose =
    Seq.unfold 
        (fun number ->
            if number = 0 then None
            else Some(number % 10, number / 10))

let isPalindrome number =
    not (Seq.zip (decompose number) (decompose number |> Seq.rev)
        |> Seq.exists (fun (x, y) -> x <> y))

let minproduct = pown 10 (digits - 1)
let maxproduct = (pown 10 digits) - 1

let cartesianProducts = 
    {minproduct..maxproduct}
    |> Seq.map
        (fun x -> 
            {x..maxproduct}
            |> Seq.map (fun y -> (x, y)))
    |> Seq.collect (fun x -> x)

let results = cartesianProducts |> Seq.map (fun (p1, p2) -> p1 * p2)
let palindromes = results |> Seq.filter isPalindrome
let maxPalindrome = palindromes |> Seq.max
 