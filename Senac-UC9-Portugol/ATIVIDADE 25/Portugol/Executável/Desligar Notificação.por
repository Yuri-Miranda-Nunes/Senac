programa {
  inteiro NOT
  funcao inicio() {
    escreva("Usuário deseja receber notificações? 1 pra sim e 0 pra não: ")
      leia (NOT)
    se (nao (NOT >= 1)) {
      escreva ( " Notificações desativadas " )
    } senao {
      escreva ( " Notificações Ativadas " )
    }

  }
}
