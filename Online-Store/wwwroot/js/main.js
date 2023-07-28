const handleDomContentLoaded = function () {
    const body = document.body;
    const nav = document.querySelector('.navigation');
    const burgerBtn = document.querySelector('header .nav-btn');
    const burgetBtn2 = document.querySelector('.nav .nav-btn');
    const overlay = document.querySelector('.header .overlay');

    function handleBurgerClick() {
        if (nav.classList.contains('is-active')) {
            closeNavigation();
        } else {
            openNavigation();
        }
    }

    function closeNavigation() {
        body.classList.remove('disable-scroll');
        nav.classList.remove('is-active');
    }

    function openNavigation() {
        body.classList.add('disable-scroll');
        nav.classList.add('is-active');
    }
    burgerBtn.addEventListener('click', handleBurgerClick);
    burgetBtn2.addEventListener('click', handleBurgerClick);
    nav.addEventListener('click', closeNavigation);
}
document.addEventListener('DOMContentLoaded', handleDomContentLoaded);
