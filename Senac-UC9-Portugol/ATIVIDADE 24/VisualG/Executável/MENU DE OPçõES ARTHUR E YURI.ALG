Algoritmo "Menu de Opções Arthur e Yuri"
// Descrição: Menu de Opções
var

   num1,num2,quadrado:inteiro

Inicio
   repita ate (num2 >= 1) e (num2 <= 3)
      escreval("1. Verificar se um número é par ou ímpar.")
      escreval("2. Calcular o quadrado de um número.")
      escreval("3. Encerrar o programa.")
      escreval("")
      escreval("Escolha uma das opções: ")
      leia(num2)
      se (num2 < 1) ou (num2 >3) entao
         escreval("Opção Inválida.")
         escreval("Escolha 1,2 ou 3")
      fimse
      se num2 = 1 entao
         escreval("Digite um número: ")
         leia(num1)
         escreval("Escolha: ", num2)
         escreval("Digite o número: ", num1)
         se (num1 mod 2 = 0) entao
            escreval("Resultado: par")
         senao
            escreval("Resultado: ímpar")
         fimse
      fimse
      se num2 = 2 entao
         escreval("Digite um número: ")
         leia(num1)
         escreval("Escolha: ", num2)
         escreval("Digite o número: ", num1)
         quadrado <- num1 * num1
         escreval("Resultado: ",quadrado)
      fimse
      se num2 = 3 entao
         escreval("Fim do Programa")
      fimse
      escreval("")
   ate num2 = 3 entao


Fimalgoritmo