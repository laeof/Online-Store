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
}

function showRegisterForm() {
    registerForm.style.display = "flex";
    loginForm.style.display = "none";
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
