module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.

let collatz n =
    let rec times k m = 
        if m=1 then k
        elif (m%2=0) then times (k+1) (m/2)
        else times (k+1) (3*m+1)
    times 0 n