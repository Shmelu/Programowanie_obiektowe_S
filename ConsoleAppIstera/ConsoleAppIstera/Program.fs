// Learn more about F# at http://fsharp.org

open System
// zadanie 1
printf "Podaj swoje imie: "
let a = Console.ReadLine()
printfn "Twoje imie: %s" a
printf "\n"
//zadanie 2
printf "Podaj swoje nazwisko: "
let b = Console.ReadLine()
printfn "Twoje imie i nazwisko: %s %s" a b
printf "\n"
// zadanie 3
let objWalec promien dlugosc : float =
    promien * promien * System.Math.PI * dlugosc
let obj = objWalec 3.0 5.0
printfn "Objetosc walca: %g " obj
printf "\n"
// zadanie 4
let poleKwadratu dlugoscBoku : float =
    dlugoscBoku * dlugoscBoku
let poleK = poleKwadratu 4.5
printfn "Pole kwadratu: %g" poleK
printf "\n"
let obwodKwadratu dlugoscBoku : float = 
    4.0 * dlugoscBoku
let obwodK = obwodKwadratu 6.2
printfn "Obwod kwadratu: %g" obwodK
printf "\n"
let poleProsotkata bok1 bok2 : float =
    bok1 * bok2
let poleP = poleProsotkata 3.4 5.2
printfn "Pole prostokata: %g" poleP
printf "\n"
let obwodProstokata bok1 bok2 : float =
    bok1 * 2.0 + bok2 * 2.0
let obwodP = obwodProstokata 5.6 6.0
printfn "Obwod prostokata: %g" obwodP
printf "\n"
let poleKola promien : float =
    System.Math.PI * promien * promien
let poleKK = poleKola 5.0
printfn "Pole kola: %g" poleKK
printf "\n"
let obwodKola promien : float =
    System.Math.PI * promien * 2.0
let obwodKK = obwodKola 6.0
printfn "Obwod kola: %g" obwodKK
printf "\n"
// zadanie 5
let oblicz x y : float = 
    -5.0 * y**4.0 + 1.0/3.0 * x**2.0 + 3.0 * y - 7.0
let wielomian = oblicz 4.0 2.0
printfn "Wynik wielomianu: %g" wielomian
printf "\n"
//zadanie 6
let rec funkcja n a q : int = 
    if n = 1 then 
        
        
        
    else
         printfn "BLAD"
Console.ReadKey() |> ignore