document.addEventListener('DOMContentLoaded', function () {
    window.addEventListener('scroll', function () {
        const hero = document.querySelector('.hero-section');
        const scrolled = window.pageYOffset;
        hero.style.backgroundPositionY = scrolled * 0.5 + 'px';
    });

    let currentSlide = 0;
    const testimonials = document.querySelectorAll('.testimonial-card');

    function showSlide(index) {
        testimonials.forEach((testimonial, i) => {
            testimonial.style.transform = `translateX(${100 * (i - index)}%)`;
            testimonial.style.opacity = i === index ? '1' : '0.5';
        });
    }

    showSlide(currentSlide);

    setInterval(() => {
        currentSlide = (currentSlide + 1) % testimonials.length;
        showSlide(currentSlide);
    }, 5000);

    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
            e.preventDefault();
            document.querySelector(this.getAttribute('href')).scrollIntoView({
                behavior: 'smooth'
            });
        });
    });
});