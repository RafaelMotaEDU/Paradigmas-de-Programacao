// Learn more about F# at http://fsharp.org

open System

let quadrado numero = 
    numero * numero
    
   
let ePar numero = 
    if numero % 2 = 0 then
        2
    else
        -1

let modulo valor =
    if valor <= 0 then 
        valor * -1
    else
        printfn "valor ja é positivo"
        valor

let mediaAritmetica valor1 valor2 = 
    (valor1 + valor2) / 2.0

let menorNumero valor1 valor2 valor3 =
    if(valor1 < valor2 && valor1 < valor3) then
        valor1
    elif (valor1 > valor2 && valor2 < valor3) then
        valor2
    else
        valor3
        
let triangulos valor1 valor2 valor3 =
    if(valor1 = valor2 && valor1 = valor3) then
        printfn "Triangulo equilatero"
        0
    elif(valor1 = valor2 || valor2 = valor3 || valor1 = valor3) then
        printfn "Triangulo isosceles"
        1
    else
        printfn "Triangulo escaleno"
        2
        

[<EntryPoint>]
let main argv =
    printfn "Quadrado do numero: %f" (quadrado 3.5)
    printfn "Impar ou Par:%i" (ePar 2)
    printfn "Modulo: %i" (modulo 4)
    printfn "Media aritmetica: %f" (mediaAritmetica 4.5 3.0)
    printfn "Menor numero: %i" (menorNumero 5 2 3)
    printfn "Triangulo: %i" (triangulos 5 2 1)


    0 // return an integer exit code
