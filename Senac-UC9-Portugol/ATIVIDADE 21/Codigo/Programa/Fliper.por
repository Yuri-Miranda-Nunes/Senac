programa
{
    funcao inicio()
    {
        // Declaração das variáveis
        inteiro P, R

        // Entrada dos valores das portinhas
        leia(P, R)

        // Verifica o caminho da bolinha
        se (P == 0) {
            escreva("C") // A bolinha cai no caminho C
        } senao {
            se (R == 0) {
                escreva("B") // A bolinha cai no caminho B
            } senao {
                escreva("A") // A bolinha cai no caminho A
            }
        }
    }
}
