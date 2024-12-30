# F# Mutable Variable Behavior in Functions

This example demonstrates a common misunderstanding in F# concerning mutable variables and their behavior within functions.  In F#, functions generally receive copies of their arguments.  This means changes made to mutable variables outside the function's scope are not reflected within the function itself unless they are explicitly passed as mutable references.

## The Bug

The `bug.fs` file contains code that illustrates the issue.  A function `add` is defined to take two integers and return their sum. However, changes to the mutable variables `x` and `y` outside the function do not affect the function's output.

## The Solution

The solution, in `bugSolution.fs`, shows how to correctly use mutable variables within the function if the intention is to modify them directly and reflect these changes outside the function. This involves using mutable references or by-ref parameters.