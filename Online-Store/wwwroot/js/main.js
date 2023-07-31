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
if (prevButton != null)
    prevButton.addEventListener('click', () => {
        prevSlide();
        updateActiveDot();
    });

if (nextButton != null)
    nextButton.addEventListener('click', () => {
        nextSlide();
        updateActiveDot();
    });

let currentSlide = 0;

function showSlide(slideIndex) {
    if (slidesContainer != null)
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

document.addEventListener('DOMContentLoaded', showSlide(currentSlide));


const modal = document.getElementById("myModal");
const openModalBtn = document.getElementById("openModalBtn");
const modal_content = document.getElementById('modal-content');
const closeModalBtn = document.getElementsByClassName("close")[0];
const loginForm = document.getElementById("loginForm");
const registerForm = document.getElementById("registerForm");
const modalTitle = document.getElementById("modalTitle");
const toggleFormLink = document.getElementById("toggleForm");

function openModal() {
    modal.style.visibility = "visible";
    modal_content.style.transform = 'translateY(0)';
    showLoginForm();
}

function closeModal() {
    modal.style.visibility = "hidden";
    modal_content.style.transform = 'translateY(-100%)';
}

function showLoginForm() {
    loginForm.style.display = "flex";
    registerForm.style.display = "none";

    modalTitle.textContent = "Вход";
}

function showRegisterForm() {
    registerForm.style.display = "flex";
    loginForm.style.display = "none";
    modalTitle.textContent = "Регистрация";
}

openModalBtn.addEventListener("click", openModal);
closeModalBtn.addEventListener("click", closeModal);
window.addEventListener("click", (event) => {
    if (event.target === modal) {
        closeModal();
    }
});

function toggleForm() {
    if (loginForm.style.display === "flex") {
        showRegisterForm();
    } else {
        showLoginForm();
    }
}