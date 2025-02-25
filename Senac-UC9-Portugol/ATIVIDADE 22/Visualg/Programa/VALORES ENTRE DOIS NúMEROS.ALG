Algoritmo "Valores Entre Dois Números"

var
    A, B, inici, fim, i: inteiro

inicio

    escreval("Digite o primeiro número: ")
    leia(A)
    escreval("Digite o segundo número: ")
    leia(B)


    se A < B entao
        inici <- A
        fim <- B
    senao
        inici <- B
        fim <- A
    fimse


    para i de inici ate fim faca
        escreva(i, " ")
    fimpara
fimalgoritmo