module Assignment

// DO NOT MODIFY LEFT PART OF `LET` OPERATOR

// Define following distance unit transformations
let inchToMillimeter v =
    v * 25.4; // write your code here

let footToInch x =
    x * 12.0; // write your code here

let yardToFoot v =
     // write your code here

let mileToYard mile =
    mile * 1760.0; // write your code here

(*
Use ONLY above functions and the forward pipe operator, `|>`,  to define the following unit transformation

Forward pipe operator passes the result of the left side to the function on the right side.
*)
let yardToMillimeter y =
     // write your code here

// Define the curried function `divBy1000` that has the signature `float -> float -> float`
let divBy1000 =
    fun x->x/1000.0 // write your code here

(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)
let millimeterToMeter n =
    n/1000; // write your code here

let meterToKilometer =
    fun x->x/1000.0; // write your code here

(*
Use above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)
let millimeterToKilometer =
    fun subfunction = millimeterToMeter >> meterToKilometer; // write your code here

let inchToMeter =
    fun subfunction = inchToMillimeter >> MillimeterToMeter // write your code here

let yardToKilometer =
    fun subfunction = yardToMillimeter >> MillimeterToMeter >> meterToKilometer // write your code here

let mileToMeter =
    let subfunction = miletoYard >> YardToMillimeter >> MillimeterToMeter; // write your code here


// Define following weight unit transformations
let ounceToGram v =
    v * 28.349523125; // write your code here

let poundToOunce p =
    p * 16.0;; // write your code here

let shortTonToPound t =
    t * 2000.0; // write your code here


(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)

let gramToKilogram g =
    v/1000.0; // write your code here

(*
Use ONLY above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)

let gramToMetricTon =
    fun x->x // write your code here

let poundToKilogram =
    fun x->x // write your code here

let shortTonToMetricTon =
    fun x->x // write your code here
