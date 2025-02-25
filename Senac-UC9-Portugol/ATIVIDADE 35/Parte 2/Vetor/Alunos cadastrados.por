programa
{
    cadeia Aluno[5]
    inteiro F, C

    funcao inicio()
    {
        para (inteiro i = 0; i < 5; i++)
        {
            Aluno[i] = "Não cadastrado"
        }

        enquanto (verdadeiro)
        {
            escreva("Escolha:\n 1 - Para começar\n 0 - Para encerrar\n")
            leia(F)
            
            se (F == 1)
            {
                enquanto (verdadeiro)
                {
                    escreva("Alunos cadastrados:\n")
                    para (inteiro i = 0; i < 5; i++)
                    {
                        escreva((i + 1), " - ", Aluno[i], "\n")
                    }

                    escreva("Escolha o número do aluno para cadastrar/editar (1 a 5), ou 0 para voltar ao menu principal:\n")
                    leia(C)

                    se (C >= 1 e C <= 5)
                    {
                        escreva("Insira o nome do Aluno ", C, ":\n")
                        leia(Aluno[C - 1])
                    }
                    senao se (C == 0)
                    {
                        pare
                    }
                    senao
                    {
                        escreva("Opção inválida! Tente novamente.\n")
                    }
                }
            }
            senao se (F == 0)
            {
                escreva("Programa encerrado.\n")
                pare
            }
            senao
            {
                escreva("Opção inválida! Tente novamente.\n")
            }
        }
    }
}
