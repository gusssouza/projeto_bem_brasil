const limpa_formulario = (cep, rua, bairro, cidade) => {

    cep.value = "";
    rua.value = "";
    bairro.value = "";
    cidade.value = "";
}

const complete = (conteudo, cep, rua, bairro, cidade) => {
    if (!("erro" in conteudo)) {

        console.log(conteudo.logradouro);
        rua.value = conteudo.logradouro;
        bairro.value = conteudo.bairro;
        cidade.value = conteudo.localidade;
    }
    else {

        limpa_formulario(cep, rua, bairro, cidade);
        alert("CEP não encontrado.");
    }
}

const pesquisa_cep = (cep, rua, bairro, cidade) => {
    if (cep.value != "") {
        var validacep = /^[0-9]{8}$/;

        if (validacep.test(cep.value)) {
            fetch(`https://viacep.com.br/ws/${cep.value}/json/`)
                .then(response => response.json())
                .then(conteudo => {
                    complete(conteudo, cep, rua, bairro, cidade);
                })
        }
        else {
            limpa_formulario(cep, rua, bairro, cidade);
            alert("Formato de CEP inválido");
        }
    }
    else {
        limpa_formulario(cep, rua, bairro, cidade);
    }
}


const pesquisa_pc = () => {
    const cep = document.getElementById("cepPedirComida");
    const rua = document.getElementById("ruaPedirComida");
    const bairro = document.getElementById("bairroPedirComida");
    const cidade = document.getElementById("cidadePedirComida");

    pesquisa_cep(cep, rua, bairro, cidade);
}

const pesquisa_pb = () => {
    const cep = document.getElementById("cepPedirBrinquedo");
    const rua = document.getElementById("ruaPedirBrinquedo");
    const bairro = document.getElementById("bairroPedirBrinquedo");
    const cidade = document.getElementById("cidadePedirBrinquedo");

    pesquisa_cep(cep, rua, bairro, cidade);
}

const pesquisa_pr = () => {
    const cep = document.getElementById("cepPedirRoupa");
    const rua = document.getElementById("ruaPedirRoupa");
    const bairro = document.getElementById("bairroPedirRoupa");
    const cidade = document.getElementById("cidadePedirRoupa");

    pesquisa_cep(cep, rua, bairro, cidade);
}

const pesquisa_dc = () => {
    const cep = document.getElementById("cepDoarComida");
    const rua = document.getElementById("ruaDoarComida");
    const bairro = document.getElementById("bairroDoarComida");
    const cidade = document.getElementById("cidadeDoarComida");

    pesquisa_cep(cep, rua, bairro, cidade);
}

const pesquisa_db = () => {
    const cep = document.getElementById("cepDoarBrinquedo");
    const rua = document.getElementById("ruaDoarBrinquedo");
    const bairro = document.getElementById("bairroDoarBrinquedo");
    const cidade = document.getElementById("cidadeDoarBrinquedo");;

    pesquisa_cep(cep, rua, bairro, cidade);
}

const pesquisa_dr = () => {
    const cep = document.getElementById("cepDoarRoupa");
    const rua = document.getElementById("ruaDoarRoupa");
    const bairro = document.getElementById("bairroDoarRoupa");
    const cidade = document.getElementById("cidadeDoarRoupa");

    pesquisa_cep(cep, rua, bairro, cidade);
}

const pesquisa_editar = () => {
    const cep = document.getElementById("cepEditar");
    const rua = document.getElementById("ruaEditar");
    const bairro = document.getElementById("bairroEditar");
    const cidade = document.getElementById("cidadeEditar");

    pesquisa_cep(cep, rua, bairro, cidade);
}