Algoritmo "Contador de N�meros �mpares Arthur e Yuri"
// Descri��o: Contador de N�meros �mpares
Var

   num1,num2,i:inteiro

Inicio
   escreval("Digite o n�mero de in�cio: ")
   leia(num1)
   escreval("Digite o n�mero de fim: ")
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