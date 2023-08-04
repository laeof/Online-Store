const titles = document.querySelectorAll('.cabinet-info-title');
const itemlists = document.querySelectorAll('.cabinet-info-item-list');


titles.forEach((element, index) => {
    element.addEventListener('click', () => {
        if (element.classList.contains('active')) {
            itemlists[index].classList.remove('active');
            element.classList.remove('active');
        } else {
            itemlists[index].classList.add('active');
            element.classList.add('active');
        }
    });
});

const editButtons = document.querySelectorAll('.button.white');

editButtons.forEach(button => {
    button.addEventListener('click', () => {
        const blockElement = button.closest('.cabinet-info-item-list');

        const inputElement = blockElement.querySelectorAll('.cabinet-info-input');

        inputElement.forEach(element => {
            if(element.classList.contains('active'))
            {
                element.classList.remove('active');
                blockElement.classList.remove('edit');
            }
            else
            {
                element.classList.add('active');
                blockElement.classList.add('edit');
            }
            element.readOnly = !element.readOnly;
        });
    });
});

const redButtons = document.querySelectorAll('.button.red');

redButtons.forEach(button => {
    button.addEventListener('click', () => {
        const blockElement = button.closest('.cabinet-info-item-list');

        const inputElement = blockElement.querySelectorAll('.cabinet-info-input');

        inputElement.forEach(element => {
            if(element.classList.contains('active'))
            {
                element.classList.remove('active');
                blockElement.classList.remove('edit');
            }
            else
            {
                element.classList.add('active');
                blockElement.classList.add('edit');
            }
            element.readOnly = !element.readOnly;
        });
    });
});