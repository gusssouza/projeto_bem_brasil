
var tipo = "";

function publicarPedido() {

    let SelectPublicarPedido = document.querySelector('#selectTelaPedir');
    let btnSubmit = document.getElementById("btnSubmit");
    let value = SelectPublicarPedido.options[SelectPublicarPedido.selectedIndex].value;

    let divPublicarComida = document.getElementById("divPublicarComida");
    let divPublicarRoupa = document.getElementById("divPublicarRoupa");
    let divPublicarBrinquedo = document.getElementById("divPublicarBrinquedo");


    if (value == 1) {
        tipo = "comida";
        btnSubmit.style = "visible !important;";
        divPublicarComida.style = "visible !important;";
        divPublicarRoupa.style = "hidden !important;";
        divPublicarBrinquedo.style = "hidden !important;";

    } else if (value == 2) {
        divPublicarRoupa.style = "visible !important;";
        btnSubmit.style = "visible !important;";
        divPublicarComida.style = "hidden !important;";
        divPublicarBrinquedo.style = "hidden !important;";

    } else if (value == 3) {
        divPublicarBrinquedo.style = "visible !important;";
        btnSubmit.style = "visible !important;";
        divPublicarRoupa.style = "hidden !important;";
        divPublicarComida.style = "hidden !important;";
    }
}




















































function adicionarComida() { 
    let titulo = document.getElementById("inputTituloPedir").value;
    let validade = document.getElementById("inputValidadePedir").value;
    let imagem = document.getElementById("inputLinkPedir").value;
    let cidade = document.getElementById("inputCidadePedir").value;
    let descricao = document.getElementById("exampleFormControlTextarea2").value;
    let div = document.getElementById("divIndexPedido")


    if (tipo == "comida") { 
        
        
      div.innerHTML += `
    <div class="col">

<div class="card" style="width: 18rem;">
    <img src="${imagem}" class="card-img-top" alt="...">
    <div class="card-body">
        <h5 class="card-title">${titulo}</h5>
        <h3 id="cardItens" class="card-text">Descrição: ${descricao}</h3>
        <h3 id="cardItens" class="card-text">Validade: ${validade}</h3>
        <h3 id="cardItens" class="card-text">Quantidade: ${quantidade}</h3>
        <h3 id="cardItens" class="card-text">Localização:  ${cidade}</h3>
    <a href="#" class="btn btn-primary" style="
      background-color: #3bca78;"
      box-shadow: 0 4px 9px -4px #2c9f4a;>Doar</a>
    </div>
  </div>

    </div>
`
        titulo = "";
        validade = "";
        imagem = "";
        cidade = "";
        descricao = "";
    
    }
}