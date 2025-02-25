programa
{
    funcao inicio()
    {
        inteiro M[4][4] 
        inteiro I, J

        para (I = 0; I < 4; I++)
        {
            para (J = 0; J < 4; J++)
            {
                escreva("Digite o número para a posição [", I + 1, "][", J + 1, "]: ")
                leia(M[I][J])
            }
        }

        escreva("\nOs números da diagonal principal são: ")
        para (I = 0; I < 4; I++)
        {
            escreva(M[I][I])
            se (I < 3)
            {
                escreva(", ")
            }
        }
    }
}
