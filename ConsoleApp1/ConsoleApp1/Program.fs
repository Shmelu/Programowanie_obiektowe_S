// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
 //   let rec fib n a =
 //       if n <= 2 then 1
 //       else fib (n - 1) a + a*fib (n - 2) a
    let rec fa a1 q n =
        if n <= 2 then a1
        else fa a1 q (n-1) * q

 //   let u = Math.PI
 //   printfn "podaj wartosc:"
    let u = fa 1 2 5
 //let v = (double) Console.ReadLine()
    printfn "Answer: %i" u
    Console.ReadKey() |> ignore
    0 // return an integer exit code
