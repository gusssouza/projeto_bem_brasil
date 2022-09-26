// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function publicar() { 

let SelectPublicar = document.querySelector('#selectTelaDoacao');
let divInner = document.getElementById("divPublicarDoacao");
let value = SelectPublicar.options[SelectPublicar.selectedIndex].value;
let btnSubmitDoar = document.getElementById("btnSubmit");
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

    <!-- Message -->
    <div class="form-group">
        <textarea class="form-control rounded-0" id="exampleFormControlTextarea2" rows="3" placeholder="Descrição"></textarea>
    </div>

</form>
<!-- Default form contact -->
`
     btnSubmitDoar.style = "visible !important;";
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

    <!-- Message -->
    <div class="form-group">
        <textarea class="form-control rounded-0" id="exampleFormControlTextarea2" rows="3" placeholder="Descrição"></textarea>
    </div>

</form>
<!-- Default form contact -->`
        btnSubmitDoar.style = "visible !important;";
    } else if (value == 3) {

        divInner.innerHTML = `<!-- Tela escolha Brinquedo -->
<form class="text-center border border-light p-5" action="#!">

    <p class="h4 mb-4">Doação</p>

    <!-- Name -->

    <input type="text" id="inputTituloDoar" class="form-control mb-4" placeholder="Título">

    <!-- Validade -->
    <input type="number" id="inputQuantDoar" class="form-control mb-4" placeholder="Quantidade">

    <!-- Validade -->
    <input type="text" id="inputLinkDoar" class="form-control mb-4" placeholder="Link imagem">

    <!-- Message -->
    <div class="form-group">
        <textarea class="form-control rounded-0" id="exampleFormControlTextarea2" rows="3" placeholder="Descrição"></textarea>
    </div>

        <!-- Subject -->

</form>
<!-- Default form contact -->`
        btnSubmitDoar.style = "visible !important;"
    }
}