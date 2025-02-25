programa {
  real N1, N2
  funcao inicio() {
    
    escreva ("Digite sua primeira nota: ")
     leia (N1)
    escreva ("Digite sua segunda nota: ")
     leia (N2)
    se (N1 >= 0 e N2 >= 0) {
      se (N1 <= 10 e N2 <= 10) {
      se (N1 >= 6 e N2 >= 6) {
      escreva ("O aluno foi aprovado")
      } senao {
      escreva ("O aluno foi reprovado")
      }
    } senao {
      escreva ("Nota invalida")
    }
    } senao {
      escreva ("Nota invalida")
    }
  }
}
