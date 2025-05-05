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

// Interatividade dos cards de tecnologia
function initTechCards() {
    const cards = document.querySelectorAll('.tech-card');
    const visualizations = document.querySelectorAll('.tech-visualization');
    
    cards.forEach(card => {
        card.addEventListener('click', function() {
            // Remove a classe active de todos os cards e visualizações
            cards.forEach(c => c.classList.remove('active'));
            visualizations.forEach(v => v.classList.remove('active'));
            
            // Adiciona active ao card clicado
            this.classList.add('active');
            
            // Mostra a visualização correspondente
            const techId = this.getAttribute('data-tech');
            document.getElementById(`vis-${techId}`).classList.add('active');
        });
    });
    
    // Ativa o primeiro card por padrão
    if (cards.length > 0) {
        cards[0].click();
    }
}

// Inicialização
window.addEventListener('DOMContentLoaded', () => {
    setRealVh();
    initSideNav();
    initTechCards();
    window.addEventListener('scroll', handleScroll);
});

window.addEventListener('resize', setRealVh);

// Ativa a primeira seção ao carregar
window.addEventListener('load', () => {
    document.querySelector('.nav-dot').classList.add('active');
});