programa
{
    real Notas[3][2]
    real Medias[3]
    cadeia Resultados[3]
    inteiro I, J

    funcao inicio()
    {
        escreva("=== Registro de Notas ===\n")
        para (I = 0; I < 3; I++)
        {
            escreva("Aluno ", (I + 1), ":\n")
            para (J = 0; J < 2; J++)
            {
                escreva("Digite a nota da disciplina ", (J + 1), ": ")
                leia(Notas[I][J])
            }
        }

        para (I = 0; I < 3; I++)
        {
            Medias[I] = (Notas[I][0] + Notas[I][1]) / 2
            se (Medias[I] >= 7)
            {
                Resultados[I] = "Aprovado"
            }
            senao
            {
                Resultados[I] = "Reprovado"
            }
        }

        escreva("\n=== Resultados ===\n")
        para (I = 0; I < 3; I++)
        {
            escreva("Aluno ", (I + 1), ": Média = ", Medias[I], " - ", Resultados[I], "\n")
        }
    }
}
