// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function publicar() { 

let SelectPublicar = document.querySelector('#selectTelaDoacao');
let divInner = document.getElementById("divPublicarDoacao");
let value = SelectPublicar.options[SelectPublicar.selectedIndex].value;
    if (value == 1) {
        divInner.innerHTML = `

<!-- Default form contact -->
<form class="text-center border border-light p-5" action="#!">

    <p class="h4 mb-4">Doação</p>


    <!-- Subject -->
    <label>Tipo de alimento:</label>
    <select class="browser-default custom-select mb-4">
        <option value="1" selected>Arroz</option>
        <option value="2">Feijão</option>
        <option value="3">Carne</option>
        <option value="4">Cesta básica</option>
    </select>

    <!-- Name -->
    <input type="text" id="defaultContactFormName" class="form-control mb-4" placeholder="Nome">

    <!-- Validade -->
    <input type="text" id="defaultContactFormName" class="form-control mb-4" placeholder="Validade">

    <!-- Validade -->
    <input type="text" id="defaultContactFormName" class="form-control mb-4" placeholder="Link imagem">

    <!-- Endereco -->

    <input type="text" id="inputCepDoar" class="form-control mb-4" placeholder="Cep">

    <input type="text" id="inputRuaDoar" class="form-control mb-4" placeholder="Rua">

    <input type="text" id="inputCidadeDoar" class="form-control mb-4" placeholder="Cidade">

    <input type="text" id="inputBairroDoar" class="form-control mb-4" placeholder="Bairro">

    <input type="number" id="inputNumeroCasaDoar" class="form-control mb-4" placeholder="Número casa/apto">

    <!-- Message -->
    <div class="form-group">
        <textarea class="form-control rounded-0" id="exampleFormControlTextarea2" rows="3" placeholder="Descrição"></textarea>
    </div>



    <!-- Send button -->
    <button class="btn btn-info btn-block" type="submit"  onclick="">Públicar</button>

</form>
<!-- Default form contact -->

`
    } else if (value == 2) {
        divInner.innerHTML = `
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
    <input type="text" id="inputTituloDoar" class="form-control mb-4" placeholder="Título">

    <!-- Validade -->
    <input type="number" id="defaultContactFormName" class="form-control mb-4" placeholder="Tamanho">

    <!-- Validade -->
    <input type="text" id="defaultContactFormName" class="form-control mb-4" placeholder="Link imagem">

    
    <!-- Endereco -->

    <input type="text" id="defaultContactFormName" class="form-control mb-4" placeholder="Cep">

    <input type="text" id="inputTituloDoar" class="form-control mb-4" placeholder="Rua">

    <input type="text" id="defaultContactFormName" class="form-control mb-4" placeholder="Cidade">

    <input type="text" id="defaultContactFormName" class="form-control mb-4" placeholder="Bairro">

    <input type="number" id="defaultContactFormName" class="form-control mb-4" placeholder="Número casa/apto">

    <!-- Message -->
    <div class="form-group">
        <textarea class="form-control rounded-0" id="exampleFormControlTextarea2" rows="3" placeholder="Descrição"></textarea>
    </div>

    <!-- Send button -->
    <button class="btn btn-info btn-block" type="submit">Públicar</button>

</form>
<!-- Default form contact -->

`;
    } else if (value == 3) {

        divInner.innerHTML = `<!-- Tela escolha Brinquedo -->
<form class="text-center border border-light p-5" action="#!">

    <p class="h4 mb-4">Doação</p>

        <label>Subject</label>
    <select class="browser-default custom-select mb-4">
        <option value="" disabled></option>
        <option value="1" selected>Inverno</option>
        <option value="2">Verão</option>
        <option value="3">Infantil</option>
        <option value="4">Adulta</option>
    </select>

    <!-- Name -->

    <input type="text" id="inputTituloDoar" class="form-control mb-4" placeholder="Título">

    <!-- Validade -->
    <input type="number" id="inputQuantDoar" class="form-control mb-4" placeholder="Quantidade">

    <!-- Validade -->
    <input type="text" id="inputLinkDoar" class="form-control mb-4" placeholder="Link imagem">

    
    <!-- Endereco -->

    <input type="text" id="inputCepDoar" class="form-control mb-4" placeholder="Cep">

    <input type="text" id="inputRuaDoar" class="form-control mb-4" placeholder="Rua">

    <input type="text" id="inputCidadeDoar" class="form-control mb-4" placeholder="Cidade">

    <input type="text" id="inputBairroDoar" class="form-control mb-4" placeholder="Bairro">

    <input type="number" id="inputNumeroCasaDoar" class="form-control mb-4" placeholder="Número casa/apto">

    <!-- Message -->
    <div class="form-group">
        <textarea class="form-control rounded-0" id="exampleFormControlTextarea2" rows="3" placeholder="Descrição"></textarea>
    </div>

        <!-- Subject -->

    <!-- Send button -->
    <button class="btn btn-info btn-block" type="submit">Públicar</button>

</form>
<!-- Default form contact -->`}
}