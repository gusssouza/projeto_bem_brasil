﻿
var tipo = "";

function publicarPedido() {

    let SelectPublicarPedido = document.querySelector('#selectTelaPedir');
    let divInnerPedido = document.getElementById("divPublicarPedido");
    let value = SelectPublicarPedido.options[SelectPublicarPedido.selectedIndex].value;
    if (value == 1) {
        tipo = "comida";
        divInnerPedido.innerHTML = `


<!-- Default form contact -->

<form class="text-center border border-light p-5" action="#!">

    <p class="h4 mb-4">Doação</p>


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

    <!-- Endereco -->

    <input type="text" id="inputCepPedir" class="form-control mb-4" placeholder="Cep">

    <input type="text" id="inputRuaPedir" class="form-control mb-4" placeholder="Rua">

    <input type="text" id="inputCidadePedir" class="form-control mb-4" placeholder="Cidade">

    <input type="text" id="inputBairroPedir" class="form-control mb-4" placeholder="Bairro">

    <input type="number" id="inputNumeroCasaPedir" class="form-control mb-4" placeholder="Número casa/apto">

    <!-- Message -->
    <div class="form-group">
        <textarea class="form-control rounded-0" id="exampleFormControlTextarea2" rows="3" placeholder="Descrição"></textarea>
    </div>



    <!-- Send button -->
    <button class="btn btn-primary me-3" type="submit" style="margin-top: 25px; margin-bottom: 25px;">Públicar</button>

</form>
<!-- Default form contact -->

`
    } else if (value == 2) {

        divInnerPedido.innerHTML = `
<!-- Tela escolha Roupa -->
<form class="text-center border border-light p-5" action="#!">

    <p class="h4 mb-4">Doação</p>

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

    
    <!-- Endereco -->

    <input type="text" id="inputCepPedir" class="form-control mb-4" placeholder="Cep">

    <input type="text" id="inputTituloPedir" class="form-control mb-4" placeholder="Rua">

    <input type="text" id="inputCidadePedir" class="form-control mb-4" placeholder="Cidade">

    <input type="text" id="inputBairroPedir" class="form-control mb-4" placeholder="Bairro">

    <input type="number" id="inputBairroNumPedir" class="form-control mb-4" placeholder="Número casa/apto">

    <!-- Message -->
    <div class="form-group">
        <textarea class="form-control rounded-0" id="exampleFormControlTextarea2" rows="3" placeholder="Descrição"></textarea>
    </div>

    <!-- Send button -->
    <button class="btn btn-primary me-3" type="submit" style="margin-top: 25px; margin-bottom: 25px;">Públicar</button>

</form>
<!-- Default form contact -->

`;
    } else if (value == 3) {

        divInnerPedido.innerHTML = `<!-- Tela escolha Brinquedo -->
<form class="text-center border border-light p-5" action="#!">

    <p class="h4 mb-4">Preciso disso</p>

        <label>Subject</label>
    <select class="browser-default custom-select mb-4">
        <option value="" disabled></option>
        <option value="1" selected>Inverno</option>
        <option value="2">Verão</option>
        <option value="3">Infantil</option>
        <option value="4">Adulta</option>
    </select>

    <!-- Name -->

    <input type="text" id="inputTituloPedir" class="form-control mb-4" placeholder="Título">

    <!-- Validade -->
    <input type="number" id="inputQuantPedir" class="form-control mb-4" placeholder="Quantidade">

    <!-- Validade -->
    <input type="text" id="inputLinkPedir" class="form-control mb-4" placeholder="Link imagem">

    
    <!-- Endereco -->

    <input type="text" id="inputCepPedir" class="form-control mb-4" placeholder="Cep">

    <input type="text" id="inputRuaPedir" class="form-control mb-4" placeholder="Rua">

    <input type="text" id="inputCidadePedir" class="form-control mb-4" placeholder="Cidade">

    <input type="text" id="inputBairroPedir" class="form-control mb-4" placeholder="Bairro">

    <input type="number" id="inputNumeroCasaPedir" class="form-control mb-4" placeholder="Número casa/apto">

    <!-- Message -->
    <div class="form-group">
        <textarea class="form-control rounded-0" id="exampleFormControlTextarea2" rows="3" placeholder="Descrição"></textarea>
    </div>

        <!-- Subject -->

    <!-- Send button -->
    <button class="btn btn-primary me-3" type="submit" style="margin-top: 25px; margin-bottom: 25px;">Públicar</button>

</form>
<!-- Default form contact -->`}
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