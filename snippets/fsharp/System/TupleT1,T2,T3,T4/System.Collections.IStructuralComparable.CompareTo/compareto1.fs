﻿module compareto1

// <Snippet1>
open System

let pitchers  =  
    [| Tuple.Create("McHale, Joe", 240.1m, 221, 96)
       Tuple.Create("Paul, Dave", 233.1m, 231, 84)
       Tuple.Create("Williams, Mike", 193.2m, 183, 86)
       Tuple.Create("Blair, Jack", 168.1m, 146, 65)
       Tuple.Create("Henry, Walt", 140.1m, 96, 30)
       Tuple.Create("Lee, Adam", 137.2m, 109, 45)
       Tuple.Create("Rohr, Don", 101.0m, 110, 42) |]

// Display the array in unsorted order.
printfn "The values in unsorted order:"
for pitcher in pitchers do
    printfn $"{pitcher}"
printfn ""

// Sort the array
Array.Sort pitchers

// Display the array in sorted order.
printfn "The values in sorted order:"
for pitcher in pitchers do
    printfn $"{pitcher}"
// The example displays the following output
//       The values in unsorted order:
//       (McHale, Joe, 240.1, 221, 96)
//       (Paul, Dave, 233.1, 231, 84)
//       (Williams, Mike, 193.2, 183, 86)
//       (Blair, Jack, 168.1, 146, 65)
//       (Henry, Walt, 140.1, 96, 30)
//       (Lee, Adam, 137.2, 109, 45)
//       (Rohr, Don, 101, 110, 42)
//       
//       The values in sorted order:
//       (Blair, Jack, 168.1, 146, 65)
//       (Henry, Walt, 140.1, 96, 30)
//       (Lee, Adam, 137.2, 109, 45)
//       (McHale, Joe, 240.1, 221, 96)
//       (Paul, Dave, 233.1, 231, 84)
//       (Rohr, Don, 101, 110, 42)
//       (Williams, Mike, 193.2, 183, 86)
// </Snippet1>