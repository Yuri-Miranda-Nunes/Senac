Algoritmo "Media de Arthur e Yuri"

Var
   nota1, nota2, nota3, nota4, media:real
Inicio
   Escreval("Escreva a primeira nota")
   leia (nota1)
   Escreval("Escreva a segunda nota")
   leia (nota2)
   Escreval("Escreva a terceira nota")
   leia (nota3)
   Escreval("Escreva a quarta nota")
   leia (nota4)
   media <- ( nota1 + nota2 + (nota3 * 2) + nota4) /4
   se media < 6 entao
      escreval ("A media é ",media)
      escreval (" Reprovado ")
   senao media >= 6 entao
      escreval("A media é ",media)
      escreval(" Aprovado ")
   fimse
Fimalgoritmo