Algoritmo "Valores Entre Dois N�meros"

var
    A, B, inici, fim, i: inteiro

inicio

    escreval("Digite o primeiro n�mero: ")
    leia(A)
    escreval("Digite o segundo n�mero: ")
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