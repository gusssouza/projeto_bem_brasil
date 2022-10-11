//mudar a cor e imagem do botão da tela do anúncio;
function changeImage() {
    var back = document.getElementById('backColor');
    var image = document.getElementById('myImage');
    if ((image.src.match("/img/heart-icon-dark.png")) && (back.style.backgroundColor = "#FFF")) {
        image.src = "/img/heart-icon-light.png";
        back.style.backgroundColor = "#3bca78";
    }
    else {
        image.src = "/img/heart-icon-dark.png";
        back.style.backgroundColor = "#FFF";
    }
}

