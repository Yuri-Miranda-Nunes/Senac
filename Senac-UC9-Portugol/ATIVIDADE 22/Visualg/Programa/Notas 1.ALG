Algoritmo "NOTA"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 19/11/2024
Var
   // Se��o de Declara��es das vari�veis
   nota1,nota2,media:real

Inicio
   // Se��o de Comandos, procedimento, fun��es, operadores, etc...
   escreval ("Digite a primeira nota")
   leia(nota1)
   escreval("Digite a segunda nota")
   leia(nota2)
   media<- (nota1+nota2)/2
   se (media <4) ent�o
      escreval ("Aluno est� Reprovado")
   sen�o
      se (media>=4)e(media<7)ent�o
         escreva ("Aluno est� de recupera��o")
      sen�o
         se (media>=7)  ent�o
            escreva ("Aluno est� atendido")
         fimse
      fimse
   fimse


Fimalgoritmo