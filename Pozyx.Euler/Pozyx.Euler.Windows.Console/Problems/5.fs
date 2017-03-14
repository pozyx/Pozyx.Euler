module _5

// https://projecteuler.net/problem=5

let maxDivisor = 20

let divisors = {2..maxDivisor}

let rec gcd (a, b) =
    match (a, b) with
    | (a, 0) -> a
    | (a, b) -> gcd (b, a % b)

let lcm (a, b) = (a / gcd(a,b)) * b

let result = Seq.fold (fun acc next -> lcm(acc, next)) 1 divisors
