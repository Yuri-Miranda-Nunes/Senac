programa
{
    funcao inicio()
    {
        inteiro A, B, inici, fim, i

        escreva("Digite o primeiro número: ")
        leia(A)
        escreva("Digite o segundo número: ")
        leia(B)

        se (A < B)
        {
            inici = A
            fim = B
        }
        senao
        {
            inici = B
            fim = A
        }

        para ( i = inici ; i <= fim ; i++ )
        {
            escreva(i, " ")
        }
    }
}
