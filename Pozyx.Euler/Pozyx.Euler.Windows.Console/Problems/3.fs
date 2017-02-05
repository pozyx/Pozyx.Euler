module _3

// https://projecteuler.net/problem=3

let rec factorize n = 
    {2L..n} 
    |> Seq.filter (fun x -> n % x = 0L) 
    |> Seq.head
    |> (fun x -> 
        Seq.singleton x 
        |> Seq.append (if x = n then Seq.empty else factorize (n / x)))

let largestPrimeFactor = factorize 600851475143L |> Seq.head