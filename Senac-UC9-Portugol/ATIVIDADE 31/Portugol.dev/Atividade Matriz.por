programa
{
    funcao inicio()
    {
        real A[4][4]
        real B[4][4]
        real C[4][4]
        escreva("Preenchendo a matriz A:\n")
        para (inteiro i = 0; i < 4; i++)
        {
            para (inteiro j = 0; j < 4; j++)
            {
                escreva("Digite o valor para A[", i, "][", j, "]: ")
                leia(A[i][j])
            }
        }
        escreva("\nPreenchendo a matriz B:\n")
        para (inteiro i = 0; i < 4; i++)
        {
            para (inteiro j = 0; j < 4; j++)
            {
                escreva("Digite o valor para B[", i, "][", j, "]: ")
                leia(B[i][j])
            }
        }
        para (inteiro i = 0; i < 4; i++)
        {
            para (inteiro j = 0; j < 4; j++)
            {
                C[i][j] = A[i][j] + B[i][j]
            }
        }
        escreva("\nMatriz resultante C (soma de A e B):\n")
        para (inteiro i = 0; i < 4; i++)
        {
            para (inteiro j = 0; j < 4; j++)
            {
                escreva(C[i][j], " ")
            }
            escreva("\n")
        }
    }
}
