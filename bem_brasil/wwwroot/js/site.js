// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


let SelectPublicar = document.querySelector('#selectTelaDoacao');
let value = SelectPublicar.options[SelectPublicar.selectedIndex].value;
if (value == 1) {
    let divInner = document.getElementById("divPublicarDoacao");
    divInner.innerHTML = `

<!-- Default form contact -->
<form class="text-center border border-light p-5" action="#!">

    <p class="h4 mb-4">Doação</p>

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

        <!-- Subject -->
    <label>Tipo de alimento:</label>
    <select class="browser-default custom-select mb-4">
        <option value="1" selected>Arroz</option>
        <option value="2">Feijão</option>
        <option value="3">Carne</option>
        <option value="4">Cesta básica</option>
    </select>

    <!-- Copy -->
    <div class="custom-control custom-checkbox mb-4">
        <input type="checkbox" class="custom-control-input" id="defaultContactFormCopy">
        <label class="custom-control-label" for="defaultContactFormCopy">Send me a copy of this message</label>
    </div>

    <!-- Send button -->
    <button class="btn btn-info btn-block" type="submit">Públicar</button>

</form>
<!-- Default form contact -->

`
}