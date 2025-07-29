function converter() {
    const taxaCambio = 5.57;
    const valorDolar = parseFloat(document.getElementById("dolar").value);
    const resultDiv = document.getElementById("resultado");

    // Mostra loading
    resultDiv.innerHTML = '<div class="loading"></div>';

    // Simula um pequeno delay para efeito visual
    setTimeout(() => {
      if (isNaN(valorDolar) || valorDolar < 0) {
        resultDiv.innerHTML = '<div class="error-text">⚠️ Digite um valor válido em dólares</div>';
        return;
      }

      if (valorDolar === 0) {
        resultDiv.innerHTML = '<div class="result-text">US$ 0.00 = R$ 0.00</div>';
        return;
      }

      const valorReal = valorDolar * taxaCambio;
      resultDiv.innerHTML = `
        <div class="result-text">
          US$ ${valorDolar.toFixed(2)}<br>
          <span style="font-size: 24px;">↓</span><br>
          R$ ${valorReal.toFixed(2)}
        </div>
      `;
    }, 500);
  }

  // Permite converter pressionando Enter
  document.getElementById("dolar").addEventListener("keypress", function(event) {
    if (event.key === "Enter") {
      converter();
    }
  });

  // Auto-focus no input
  window.onload = function() {
    document.getElementById("dolar").focus();
  };