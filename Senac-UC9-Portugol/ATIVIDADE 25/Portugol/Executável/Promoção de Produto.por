programa {
  
  real PRECO
  logico CUPOM

  funcao inicio() {
    
    escreva ("Qual o valor da compra? ")
      leia (PRECO)
    escreva ("Se houver Cupom, entrada de 1 para sim e 0 para não: ")
     leia (CUPOM)
    se ( PRECO > 100 ou CUPOM == 1 ) {
      escreva ("Desconto aplicado")
    } senao {
      escreva ("Desconto não aplicado")
    }
  }
}
