let mutable x = ref 10
let mutable y = ref 20

let add x y = 
    x := !x + !y
    !x

printf "%d\n" (add x y) //This will print 30

x := 15

printf "%d\n" (add x y) //This will print 35

//Alternative solution using byref parameters

let addByRef x y = 
    x <- !x + !y

let mutable x2 = 10
let mutable y2 = 20

addByRef &x2 &y2
printf "%d\n" x2