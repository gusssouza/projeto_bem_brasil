﻿




function editarDados() {


    let div = document.getElementById('divEditar');

    let status = true;

    mensagem = document.getElementById('mensagemErroEditar');
    email = document.getElementById('form3Example3');
    senha = document.getElementById('form3Example4');


    if (status) {
        div.innerHTML = `
   <!-- Section: Design Block -->
<section class="text-center">
  <!-- Background image -->
  <div class="p-5 bg-image" style="
        background-image: url('https://mdbootstrap.com/img/new/textures/full/171.jpg');
        height: 300px;
        "></div>
  <!-- Background image -->

  <div class="card mx-4 mx-md-5 shadow-5-strong" style="
        margin-top: -100px;
        background: hsla(0, 0%, 100%, 0.8);
        backdrop-filter: blur(30px);
        ">
    <div class="card-body py-5 px-md-5">

      <div class="row d-flex justify-content-center">
        <div class="col-lg-8">
          <h2 class="fw-bold mb-5">Cadastrar-se</h2>
          <form asp-controller="Home" asp-action="CadastrarOperador" method="post">
            <!-- 2 column grid layout with text inputs for the first and last names -->
            <div class="row">
              <div class="col-md-6 mb-4">
                <div class="form-outline">
                  <input type="text" asp-for="Nome" id="form3Example1" class="form-control" />
                  <label class="form-label" for="form3Example1">Nome</label>
                </div>
              </div>

             <div class="col-md-6 mb-4">
                <div class="form-outline">
                  <input type="text" asp-for="TipoOperador" id="form3Example2" class="form-control" />
                  <label class="form-label" for="form3Example2">Sobrenome</label>
                </div>
              </div>
            
            <!-- Email input -->
            <div class="form-outline mb-4">
              <input type="email" id="form3Example3" class="form-control" />
              <label class="form-label" for="form3Example3">Endereço de Email </label>
            </div>

            <!-- Password input -->
            <div class="form-outline mb-4">
              <input type="password" id="form3Example4" class="form-control" />
              <label class="form-label" for="form3Example4">Senha</label>
            </div>

            <!-- Submit button -->
            <button type="submit" class="btn btn-primary btn-block mb-4">
              Enviar
            </button>
          </form>
        </div>
      </div>
    </div>
  </div>
</section>
<!-- Section: Design Block -->
`} else {
        mensagem.innerHTML = `
        <h1 id="h1MsgErroEditar">Dados de email e/ou senha estão incorretos</h1>
`
        email = "";
        senha = "";
    }
}