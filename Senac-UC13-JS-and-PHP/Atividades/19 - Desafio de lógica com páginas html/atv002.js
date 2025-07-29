function calcularMedia() {
    const n1 = parseInt(document.getElementById("numero1").value);
    const n2 = parseInt(document.getElementById("numero2").value);
    const resultado = document.getElementById("resultado");

    if (isNaN(n1) || isNaN(n2)) {
      resultado.innerHTML = "⚠️ Por favor, insira dois números válidos.";
      resultado.classList.add("show");
      resultado.style.background = "linear-gradient(45deg, rgba(255, 82, 82, 0.3), rgba(255, 171, 0, 0.3))";
      return;
    }

    const media = (n1 + n2) / 2;
    resultado.innerHTML = `🎯 A média aritmética é  : <strong> ${media}</strong>`;
    resultado.classList.add("show");
    resultado.style.background = "linear-gradient(45deg, rgba(131, 56, 236, 0.3), rgba(255, 0, 110, 0.3))";
  }

  // Adiciona efeito de enter para calcular
  document.addEventListener('keypress', function(e) {
    if (e.key === 'Enter') {
      calcularMedia();
    }
  });

  // Efeito de digitação nos inputs
  const inputs = document.querySelectorAll('input[type="number"]');
  inputs.forEach(input => {
    input.addEventListener('input', function() {
      if (this.value) {
        this.style.transform = 'scale(1.02)';
      } else {
        this.style.transform = 'scale(1)';
      }
    });
  });