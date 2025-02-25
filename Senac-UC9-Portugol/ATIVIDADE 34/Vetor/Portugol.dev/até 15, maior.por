programa
{
    funcao inicio()
    {
        inteiro numeros[15]
        inteiro i, maior

        para (i = 0; i < 15; i++)
        {
            escreva("Digite um número para a posição ", i + 1, ": ")
            leia(numeros[i])
        }

        maior = numeros[0]

        para (i = 1; i < 15; i++)
        {
            se (numeros[i] > maior)
            {
                maior = numeros[i]
            }
        }
        escreva("\nO maior número no vetor é: ", maior)
    }
}
