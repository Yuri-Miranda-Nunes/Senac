programa
{
    funcao inicio()
    {
        inteiro vetor[10]
        inteiro soma = 0
        
        
        para (inteiro i = 0; i < 10; i++)
        {
            escreva("Digite o valor para a posição ", i, ": ")
            leia(vetor[i])
            soma = soma + vetor[i]
        }
        
        
        escreva("Elementos do vetor: ")
        para (inteiro i = 0; i < 10; i++)
        {
            escreva(vetor[i], " ")
        }
        
        
        escreva("\nSoma dos elementos: ", soma)
    }
}
