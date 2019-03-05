// Learn more about F# at http://fsharp.org


open System

let imie = "Konrad"
let nazwisko= " Duda"
Console.WriteLine(imie+ nazwisko)
let funkcj a b c d= ((a*b)+2/(c+d))
let s2356=funkcj 2 3 5 6
Console.WriteLine(s2356)
Console.ReadKey() |> ignore