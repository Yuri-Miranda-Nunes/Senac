Algoritmo "Cofrinho da vó vitória"
Var N, J, Z, I: inteiro
Inicio
   I <- 0
   escreval("Quantos depósitos você irá fazer: ")
   leia(N)
   para I:= 1 ate N passo 1 faca
      escreval("Quantos centavos Joãozinho irá receber: ")
      leia(J)
      escreval("Quantos centavos Zezinho irá receber: ")
      leia(Z)
   fimpara
   se (J > Z) entao
      escreval("Joãozinho recebeu: ", J - Z, " a mais")
   senao
      se (J < Z) entao
         escreval("Zezinho recebeu: ", Z - J, " a mais")
      senao
         se (J = Z) entao
            escreval("Os dois receberam a mesma quantidade")
         fimse
      fimse
   fimse
Fimalgoritmo