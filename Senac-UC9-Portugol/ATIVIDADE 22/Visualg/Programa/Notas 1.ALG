Algoritmo "NOTA"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 19/11/2024
Var
   // Seção de Declarações das variáveis
   nota1,nota2,media:real

Inicio
   // Seção de Comandos, procedimento, funções, operadores, etc...
   escreval ("Digite a primeira nota")
   leia(nota1)
   escreval("Digite a segunda nota")
   leia(nota2)
   media<- (nota1+nota2)/2
   se (media <4) então
      escreval ("Aluno está Reprovado")
   senão
      se (media>=4)e(media<7)então
         escreva ("Aluno está de recuperação")
      senão
         se (media>=7)  então
            escreva ("Aluno está atendido")
         fimse
      fimse
   fimse


Fimalgoritmo