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

