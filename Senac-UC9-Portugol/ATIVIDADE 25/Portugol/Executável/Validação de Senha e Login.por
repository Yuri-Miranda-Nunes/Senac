programa {
  cadeia LOGIN
  inteiro SENHA
  funcao inicio() {
    escreva ("Login: ")
      leia (LOGIN)
    escreva ("Senha: ")
      leia (SENHA)
      se (LOGIN == "admin" e SENHA == "1234") {
        escreva ("Acesso permitido")
      } senao {
        escreva ("Acesso negado")
      }
  }
}
