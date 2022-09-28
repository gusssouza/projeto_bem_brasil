const imagem = (id) => {
    let imagens = ["../../img/bk2.png", "../../img/bk3.png", "../../img/bk4.png", "../../img/bk5.png", "../../img/bk6.png", "../../img/bk8.png"];
    let doc = document.getElementById(id);
    let img = imagens[Math.floor(Math.random() * imagens.length)];

    doc.src = img;
}

imagem("backgroundPedido");
imagem("backgroundDoar");

