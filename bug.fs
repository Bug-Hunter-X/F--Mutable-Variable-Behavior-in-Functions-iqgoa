let mutable x = 10
let mutable y = 20

let add x y = x + y

printf "%d\n" (add x y) //This will print 30

x <- 15

printf "%d\n" (add x y) //This will also print 30, not 35 because the function add is not using the mutable values from x and y, rather it's using the values that were passed during the function call.
