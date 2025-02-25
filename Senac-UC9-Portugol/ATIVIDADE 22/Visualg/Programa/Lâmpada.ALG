Algoritmo "semnome"
// Descrição:
Var
   n,i,ns:inteiro
   a,b:logico
Inicio
   a <- falso
   b <- falso
   escreval("Quantas vezes o interruptor foi apertado")
   leia(n)
   para i de 1 ate n faca
      escreval("Qual interruptor você apertou")
      leia(ns)
      se ns = 1 entao
         se a = verdadeiro entao
            a <- falso
         senao
            a <- verdadeiro
         fimse
      fimse

      se ns = 2 entao
         se a = verdadeiro entao
            a <- falso
         senao
            a <- verdadeiro
         fimse

         se b = verdadeiro entao
            b <- falso
         senao
            b <- verdadeiro
         fimse
      fimse
   fimpara
   escreval("Lâmpada A está ligada: ",a)
   escreval("Lâmpada B está ligada: ",b)

Fimalgoritmo