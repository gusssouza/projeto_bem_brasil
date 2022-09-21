
var tipo = "";

function publicarPedido() {

    let SelectPublicarPedido = document.querySelector('#selectTelaPedir');
    let divInnerPedido = document.getElementById("divPublicarPedido");
    let btnSubmit = document.getElementById("btnSubmit");
    let value = SelectPublicarPedido.options[SelectPublicarPedido.selectedIndex].value;
    if (value == 1) {
        tipo = "comida";
        divInnerPedido.innerHTML = `


<!-- Default form contact -->

<form class="text-center border border-light p-5" action="#!">

    <p class="h4 mb-4">Pedido</p>


    <!-- Subject -->
    <label>Tipo de alimento:</label>
    <select class="browser-default custom-select mb-4">
        <option value="1pedido" selected>Arroz</option>
        <option value="2pedido">Feijão</option>
        <option value="3pedido">Carne</option>
        <option value="4pedido">Cesta básica</option>
    </select>

    <!-- Name -->
   <input type="text" id="inputTituloPedir" class="form-control mb-4" placeholder="Título">

    <!-- Validade -->
    <input type="text" id="inputValidadePedir" class="form-control mb-4" placeholder="Validade">

    <!-- Validade -->
    <input type="text" id="inputLinkPedir" class="form-control mb-4" placeholder="Link imagem">


    <!-- Message -->
    <div class="form-group">
        <textarea class="form-control rounded-0" id="exampleFormControlTextarea2" rows="3" placeholder="Descrição"></textarea>
    </div>


</form>
<!-- Default form contact -->`
        btnSubmit.style = "visible !important;";
    } else if (value == 2) {

        divInnerPedido.innerHTML = `
<!-- Tela escolha Roupa -->
<form class="text-center border border-light p-5" action="#!">

    <p class="h4 mb-4">Pedido</p>

        <label>Subject</label>
    <select class="browser-default custom-select mb-4">
        <option value="" disabled>Tipo de roupa</option>
        <option value="1" selected>Inverno</option>
        <option value="2">Verão</option>
        <option value="3">Infantil</option>
        <option value="4">Adulta</option>
    </select>

    <!-- Name -->
    <input type="text" id="inputTituloPedir" class="form-control mb-4" placeholder="Título">

    <!-- Validade -->
    <input type="number" id="inputTamanhoPedir" class="form-control mb-4" placeholder="Tamanho">

    <!-- Validade -->
    <input type="text" id="inputLinkPedir" class="form-control mb-4" placeholder="Link imagem">

    <!-- Message -->
    <div class="form-group">
        <textarea class="form-control rounded-0" id="exampleFormControlTextarea2" rows="3" placeholder="Descrição"></textarea>
    </div>
</form>
<!-- Default form contact -->`
        btnSubmit.style = "visible !important;";
    } else if (value == 3) {

        divInnerPedido.innerHTML = `<!-- Tela escolha Brinquedo -->

    <p class="h4 mb-4">Pedido</p>

    <!-- Name -->

    <input type="text" id="inputTituloPedir" class="form-control mb-4" placeholder="Título">

    <!-- Validade -->
    <input type="number" id="inputQuantPedir" class="form-control mb-4" placeholder="Quantidade">

    <!-- Validade -->
    <input type="text" id="inputLinkPedir" class="form-control mb-4" placeholder="Link imagem">

    <!-- Message -->
    <div class="form-group">
        <textarea class="form-control rounded-0" id="exampleFormControlTextarea2" rows="3" placeholder="Descrição"></textarea>
    </div>   
<!-- Default form contact -->`
        btnSubmit.style = "visible !important;";
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