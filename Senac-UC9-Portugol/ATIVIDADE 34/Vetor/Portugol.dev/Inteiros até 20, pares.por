programa
{
    funcao inicio()
    {
        inteiro Numeros[20]
        inteiro I, Pares = 0

        para (I = 0; I < 20; I++)
        {
            escreva("Digite um número para a posição ", I + 1, ": ")
            leia(Numeros[I])
        }

        para (I = 0; I < 20; I++)
        {
            se (Numeros[I] % 2 == 0)
            {
                Pares++
            }
        }

        escreva("\nO vetor contém ", Pares, " números pares.")
    }
}
