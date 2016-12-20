module _2

// https://projecteuler.net/problem=2

let upperBound = 4000000
let fibSeq = Seq.unfold (fun state -> 
    Some(fst state + snd state, (snd state, fst state + snd state))) (0, 1)
let ofValueBelow x seq = seq |> Seq.takeWhile (fun n -> n <= x)
let even seq = seq |> Seq.filter(fun n -> n % 2 = 0)
let sum = fibSeq |> ofValueBelow upperBound |> even |> Seq.sum