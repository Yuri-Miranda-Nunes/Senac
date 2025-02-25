Algoritmo "Contador de Números ímpares Arthur e Yuri"
// Descrição: Contador de Números ímpares
Var

   num1,num2,i:inteiro

Inicio
   escreval("Digite o número de início: ")
   leia(num1)
   escreval("Digite o número de fim: ")
   leia(num2)
   se (num1 mod 2 = 0) entao
      num1 <- num1 + 1
   fimse
   i <- num1
   enquanto i <= num2 faca
      escreva(i, " ")
      i <- i + 2
   fimenquanto
fimalgoritmo