programa
{
    funcao inicio()
    {
        inteiro M[3][3] 
        inteiro I, J, S = 0

        para (I = 0; I < 3; I++)
        {
            para (J = 0; J < 3; J++)
            {
                escreva("Digite o número para a posição [", I + 1, "][", J + 1, "]: ")
                leia(M[I][J])
            }
        }

        para (I = 0; I < 3; I++)
        {
            para (J = 0; J < 3; J++)
            {
               S = S + M[I][J]
            }
        }

        escreva("\nA Soma dos elementos da Matrix é: ", S)
    }
}
  