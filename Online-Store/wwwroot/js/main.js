const sidebar = document.getElementById('sidebar');
const overlay = document.getElementById('overlay');
const body = document.body;

function toggleSideBar(){
    if(sidebar.classList.contains('notactive')){
        sidebar.classList.remove('notactive');
        overlay.classList.add('active')
        body.classList.add('disable-scroll');
    }
    else{
        sidebar.classList.add('notactive');
        overlay.classList.remove('active');
        body.classList.remove('disable-scroll');
    }
}

$(document).ready(function () {
    let selectedStar = 0;

    $(".star").hover(function () {
        let starNumber = parseInt($(this).data("star"));

        $(".star").removeClass("selected");

        for (let i = 1; i <= starNumber; i++) {
            $(`#star${i}`).addClass("selected");
        }
    }, function () {
        $(".star").removeClass("selected");
    });
});

overlay.addEventListener('click', toggleSideBar);

const slidesContainer = document.querySelector('.slides');
const slides = document.querySelectorAll('.slides img');
const prevButton = document.querySelector('.prev-btn');
const nextButton = document.querySelector('.next-btn');
const dots = document.querySelectorAll('.dot');

function updateActiveDot() {
    dots.forEach((dot, index) => {
        if (index === currentSlide) {
            dot.classList.add('active');
        } else {
            dot.classList.remove('active');
        }
    });
}

dots.forEach((dot, index) => {
    dot.addEventListener('click', () => {
        currentSlide = index;
        showSlide(currentSlide);
        updateActiveDot();
    });
});

prevButton.addEventListener('click', () => {
    prevSlide();
    updateActiveDot();
});

nextButton.addEventListener('click', () => {
    nextSlide();
    updateActiveDot();
});

let currentSlide = 0;

function showSlide(slideIndex) {
    slidesContainer.style.transform = `translateX(-${slideIndex * 100}%)`;
}

function nextSlide() {
    currentSlide = (currentSlide + 1) % slides.length;
    showSlide(currentSlide);
}

function prevSlide() {
    currentSlide = (currentSlide - 1 + slides.length) % slides.length;
    showSlide(currentSlide);
}

updateActiveDot();

// Добавляем обработчики событий для кнопок "Next" и "Prev"
document.addEventListener('DOMContentLoaded', showSlide(currentSlide));