programa
{
    funcao inicio()
    {
        real nota1, nota2, media

        escreva("Digite a primeira nota \n")
        leia(nota1)
        escreva("Digite a segunda nota \n")
        leia(nota2)

        media = (nota1 + nota2) / 2

        se (media < 4)
        {
            escreva("Aluno está Reprovado \n")
        }
        senao
        {
            se (media >= 4 e media < 7)
            {
                escreva("Aluno está de recuperação \n")
            }
            senao
            {
                se (media >= 7)
                {
                    escreva("Aluno está aprovado \n")
                }
            }
        }
    }
}
