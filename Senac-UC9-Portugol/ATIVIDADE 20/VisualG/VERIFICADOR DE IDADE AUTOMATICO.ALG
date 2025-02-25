Algoritmo "Verificador de idade automatico"

Var
    idade: inteiro
Inicio
    escreval ("Qual a sua idade individuo?")
    leia (idade)
    se (idade < 12) entao
    escreval ("Criança")
    fimse
    se (idade >= 12) e (idade <= 17) entao
    escreval ("Adolescente")
    fimse
    se (idade >= 18) entao
    escreval ("Adulto")
    fimse
Fimalgoritmo