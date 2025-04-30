// Correção para altura mobile (100vh)
function setRealVh() {
    let vh = window.innerHeight * 0.01;
    document.documentElement.style.setProperty('--vh', `${vh}px`);
}

// Ativa o menu lateral conforme scroll
function handleScroll() {
    const sections = document.querySelectorAll('.section');
    const navDots = document.querySelectorAll('.nav-dot');
    
    sections.forEach((section, index) => {
        const rect = section.getBoundingClientRect();
        if (rect.top <= window.innerHeight / 2 && rect.bottom >= window.innerHeight / 2) {
            navDots.forEach(dot => dot.classList.remove('active'));
            navDots[index].classList.add('active');
        }
    });
}

// Scroll suave para o menu lateral
function initSideNav() {
    document.querySelectorAll('.nav-dot').forEach(dot => {
        dot.addEventListener('click', function() {
            const targetId = this.getAttribute('data-section');
            const targetSection = document.getElementById(targetId);
            
            if (targetSection) {
                targetSection.scrollIntoView({
                    behavior: 'smooth'
                });
            }
        });
    });
}

// Inicialização
window.addEventListener('DOMContentLoaded', () => {
    setRealVh();
    initSideNav();
    window.addEventListener('scroll', handleScroll);
});

window.addEventListener('resize', setRealVh);

// Ativa a primeira seção ao carregar
window.addEventListener('load', () => {
    document.querySelector('.nav-dot').classList.add('active');
});
 // Atualiza o gradiente quando a janela é redimensionada
 function updateGradient() {
    const penultimaSection = document.querySelector('#section3');
    const ultimaSection = document.querySelector('#section4');
    
    // Obtém a cor computada da penúltima seção
    const styles = window.getComputedStyle(penultimaSection);
    const bgColor = styles.backgroundColor;
    
    // Atualiza as variáveis CSS
    document.documentElement.style.setProperty('--color-penultima', bgColor);
    
    // Se quiser manter uma cor fixa para a última seção:
    // document.documentElement.style.setProperty('--color-ultima', '#fff8e6');
}

// Inicialização
window.addEventListener('DOMContentLoaded', () => {
    setRealVh();
    updateGradient();
});

window.addEventListener('resize', () => {
    setRealVh();
    updateGradient();
});