
// 1. Faça uma função que receba 2 valores e retorne a divisão do maior pelo menor.

let DividindoMaiorPeloMenor numero1 numero2 =
    if(numero1 >= numero2) then 
        (numero1 / numero2)
    else 
        (numero2 / numero1)

// 2. Faça uma função que receba 3 valores e escreva que tipo de triângulo eles formam:
//  a) Não forma um triângulo - Uma das medidas é maior que a soma das outras duas
//  b) Equilátero - Todos os lados iguais
//  c) Isósceles - Dois lados iguais
//  d) Escaleno - Todos os lados diferentes

let triangulos valor1 valor2 valor3 =
    if(valor1 >= valor2 + valor3 || valor2 >= valor1 + valor3 || valor3 >= valor1 + valor2) then
        printfn "Nao forma um triangulo"
    elif(valor1 = valor2 && valor1 = valor3) then
        printfn "Triangulo equilatero"
    elif(valor1 = valor2 || valor2 = valor3 || valor1 = valor3) then
        printfn "Triangulo isosceles"
    else
        printfn "Triangulo escaleno"

// 3. Faça uma função que a partir de um vetor [0..20] e faça o seguinte processo:

//  a) Primeiro filtre os valores para deixar somente pares do vetor (List.filter) 
//  b) Depois multiplique cada valor por 2 (List.map)
//  c) Por último filtre novamente os valores, agora para deixar somente os múltiplos de 6

// As operações devem ser aplicadas utilizando o operador pipe ( |> ).

let multiplosDeSeisDosParesDobrados =
    let verificarNumeroPar numero = 
        numero % 2 = 0
    let multiplicaPor2 numero = 
        numero * 2
    let multiplosDeSeis numero = 
        numero % 6 = 0

    [0..20] 
    |> List.filter verificarNumeroPar 
    |> List.map multiplicaPor2 
    |> List.filter multiplosDeSeis

// 4. Faça uma função em que o usuário digite 3 números e calcule a média entre elas, 
//  outra função que retorna se a média é acima ou abaixo da 6.0 e uma terceira, 
//  que a partir da informação booleana de aprovado ou reprovado, escreve uma 
//  mensagem correspondente ao resultado na tela. Essas funções devem estar aninhadas 
//  dentro de uma função resultado_notas que deve chamar as 3 funções internas utilizando pipeline.

let resultadoNotas valor1 valor2 valor3 =
    
    let calcularmedia  =
        (valor1 + valor2 + valor3) / 3.0

    let verificarmediaacimaouabaixo media = 
        media >= 6.0

    let aprovadooureprovado resultado = 
       if(resultado) then printf "aprovado!" 
       else printf "reprovado!"
    
    let media = 
        calcularmedia
    
    media
    |> verificarmediaacimaouabaixo 
    |> aprovadooureprovado
   
[<EntryPoint>]
let main argv =
    printfn "Digite os 2 valores a serem divididos: " 
    let valor1 = (System.Console.ReadLine() |> System.Double.Parse)
    let valor2 = (System.Console.ReadLine() |> System.Double.Parse)

    printfn "Dividindo maior pelo menor: %0.2f" (DividindoMaiorPeloMenor valor1 valor2)

    printfn "Digite os 3 valores do triangulo: " 
    let lado1 = System.Console.ReadLine() |> System.Int32.Parse
    let lado2 = System.Console.ReadLine() |> System.Int32.Parse
    let lado3 = System.Console.ReadLine() |> System.Int32.Parse

    triangulos lado1 lado2 lado3

    printf "[1..20] Multiplos de 6 dos pares dobrados: "
    for num in multiplosDeSeisDosParesDobrados do
        printf "%i " num
        // Como esta acontecendo: 
        // 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20
        // 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40
        // 0, 12, 24, 36
   
    printfn "\nDigite as 3 notas: " 
    let nota1 = System.Console.ReadLine() |> System.Double.Parse
    let nota2 = System.Console.ReadLine() |> System.Double.Parse
    let nota3 = System.Console.ReadLine() |> System.Double.Parse

    resultadoNotas nota1 nota2 nota3
    
    0
