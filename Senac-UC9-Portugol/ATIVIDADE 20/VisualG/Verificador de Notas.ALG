Algoritmo "Verificador de idade automatico"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi

Var
   idade: inteiro
Inicio
   escreval ("Qual a sua idade individuo?")
   leia (idade)
   se (idade < 5) entao
      escreval ("Aluno n�o atendido")
   fimse
   se (idade >= 5) e (idade <= 7) entao
      escreval ("Aluno parcialmente atendido")
   fimse
   se (idade > 7) entao
      escreval ("Aluno est� atendido")
   fimse
Fimalgoritmo