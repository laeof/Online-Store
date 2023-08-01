const slidesContainer = document.querySelector('.slides');
const slides = document.querySelectorAll('.slides img');
const prevButton = document.querySelector('.prev-btn');
const nextButton = document.querySelector('.next-btn');
const dots = document.querySelectorAll('.dot');
const thumbs = document.querySelectorAll('.thumb');

function updateActiveDot() {
    dots.forEach((dot, index) => {
        if (index === currentSlide) {
            dot.classList.add('active');
        } else {
            dot.classList.remove('active');
        }
    });
}

function updateActiveThumb() {
    thumbs.forEach((thumb, index) => {
        if (index === currentSlide) {
            thumb.classList.add('active');
        } else {
            thumb.classList.remove('active');
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

thumbs.forEach((thumb, index) => {
    thumb.addEventListener('click', () => {
        currentSlide = index;
        showSlide(currentSlide);
        updateActiveThumb();
    });
});

if (prevButton != null)
    prevButton.addEventListener('click', () => {
        prevSlide();
        updateActiveDot();
        updateActiveThumb();
    });

if (nextButton != null)
    nextButton.addEventListener('click', () => {
        nextSlide();
        updateActiveDot();
        updateActiveThumb();
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

function startAutoSlide() {
    clearInterval(autoSlideInterval);
    autoSlideInterval = setInterval(() => {
        nextSlide();
        updateActiveDot();
        updateActiveThumb();
    }, Interval);
}

function stopAutoSlide() {
    clearInterval(autoSlideInterval);
}

var Interval = 10000;

let autoSlideInterval = setInterval(startAutoSlide, Interval);

if (slidesContainer != null) {
    slidesContainer.addEventListener('mouseenter', stopAutoSlide);
    slidesContainer.addEventListener('mouseleave', startAutoSlide);
}

updateActiveDot();
updateActiveThumb();

document.addEventListener('DOMContentLoaded', showSlide(currentSlide));

let touchStartX = 0;
let touchEndX = 0;
let isDragging = false;
let dragStartX = 0;

slidesContainer.addEventListener('touchstart', (event) => {
    touchStartX = event.touches[0].clientX;
});

slidesContainer.addEventListener('touchmove', (event) => {
    const touch = event.touches[0];
    const touchMoveX = touch.clientX;
    const deltaX = touchMoveX - touchStartX;

    // Если слайдер на крайнем левом или правом слайде и происходит свайп влево или вправо, отключаем прокрутку страницы
    if ((currentSlide === 0 && deltaX > 0) || (currentSlide === slides.length - 1 && deltaX < 0)) {
        event.preventDefault();
    }
});

slidesContainer.addEventListener('touchend', (event) => {
    touchEndX = event.changedTouches[0].clientX;
    handleSwipe();
});

function handleSwipe() {
    const SWIPE_THRESHOLD = 50; // Порог для определения свайпа

    const deltaX = touchEndX - touchStartX;

    if (deltaX > SWIPE_THRESHOLD) {
        // Смахивание вправо, переключаем на предыдущий слайд
        prevSlide();
        updateActiveDot();
        updateActiveThumb();
    } else if (deltaX < -SWIPE_THRESHOLD) {
        // Смахивание влево, переключаем на следующий слайд
        nextSlide();
        updateActiveDot();
        updateActiveThumb();
    }
}

// Добавим обработчик события 'dragstart' для изображений
slides.forEach((slide) => {
    slide.addEventListener('dragstart', (event) => {
        event.preventDefault(); // Отключить стандартное перетаскивание изображений
    });
});

// Добавим обработчики событий для перемещения слайдов с помощью мыши
slidesContainer.addEventListener('mousedown', (event) => {
    isDragging = true;
    dragStartX = event.clientX;
});

slidesContainer.addEventListener('mousemove', (event) => {
    if (!isDragging) {
        return;
    }

    const dragCurrentX = event.clientX;
    const deltaX = dragCurrentX - dragStartX;

    if (deltaX > 0) {
        prevSlide();
        updateActiveDot();
        updateActiveThumb();
    } else if (deltaX < 0) {
        nextSlide();
        updateActiveDot();
        updateActiveThumb();
    }

    isDragging = false;
});

slidesContainer.addEventListener('mouseup', () => {
    isDragging = false;
});