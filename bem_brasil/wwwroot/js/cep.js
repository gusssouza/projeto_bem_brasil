const limpa_formulario = (cep, rua, bairro, cidade, uf) => {

    cep.value = "";
    rua.value = "";
    bairro.value = "";
    cidade.value = "";
    uf.value = ""; 
}

const complete = (conteudo, cep, rua, bairro, cidade, uf) => {
    if (!("erro" in conteudo)) {

        rua.value = conteudo.logradouro;
        bairro.value = conteudo.bairro;
        cidade.value = conteudo.localidade;
        uf.value = conteudo.uf;
    }
    else {

        limpa_formulario(cep, rua, bairro, cidade, uf);
        alert("CEP não encontrado.");
    }
}

const pesquisa_cep = (cep, rua, bairro, cidade, uf) => {
    if (cep.value != "") {
        var validacep = /^[0-9]{8}$/;

        if (validacep.test(cep.value)) {
            fetch(`https://viacep.com.br/ws/${cep.value}/json/`)
                .then(response => response.json())
                .then(conteudo => {
                    complete(conteudo, cep, rua, bairro, cidade, uf);
                })
        }
        else {
            limpa_formulario(cep, rua, bairro, cidade, uf);
            alert("Formato de CEP inválido");
        }
    }
    else {
        limpa_formulario(cep, rua, bairro, cidade, uf);
    }
}


const pesquisa_pc = () => {
    const cep = document.getElementById("cepPedirComida");
    const rua = document.getElementById("ruaPedirComida");
    const bairro = document.getElementById("bairroPedirComida");
    const cidade = document.getElementById("cidadePedirComida");
    const uf = document.getElementById("ufPedirComida");

    pesquisa_cep(cep, rua, bairro, cidade, uf);
}

const pesquisa_pb = () => {
    const cep = document.getElementById("cepDoarBrinquedo");
    const rua = document.getElementById("ruaDoarBrinquedo");
    const bairro = document.getElementById("bairroDoarBrinquedo");
    const cidade = document.getElementById("cidadeDoarBrinquedo");
    const uf = document.getElementById("ufDoarBrinquedo");

    pesquisa_cep(cep, rua, bairro, cidade, uf);
}

const pesquisa_pr = () => {
    const cep = document.getElementById("cepDoarRoupa");
    const rua = document.getElementById("ruaDoarRoupa");
    const bairro = document.getElementById("bairroDoarRoupa");
    const cidade = document.getElementById("cidadeDoarRoupa");
    const uf = document.getElementById("ufDoarRoupa");

    pesquisa_cep(cep, rua, bairro, cidade, uf);
}

const pesquisa_dc = () => {
    const cep = document.getElementById("cepDoarComida");
    const rua = document.getElementById("ruaDoarComida");
    const bairro = document.getElementById("bairroDoarComida");
    const cidade = document.getElementById("cidadeDoarComida");
    const uf = document.getElementById("ufDoarComida");

    pesquisa_cep(cep, rua, bairro, cidade, uf);
}

const pesquisa_db = () => {
    const cep = document.getElementById("cepDoarBrinquedo");
    const rua = document.getElementById("ruaDoarBrinquedo");
    const bairro = document.getElementById("bairroDoarBrinquedo");
    const cidade = document.getElementById("cidadeDoarBrinquedo");
    const uf = document.getElementById("ufDoarBrinquedo");

    pesquisa_cep(cep, rua, bairro, cidade, uf);
}

const pesquisa_dr = () => {
    const cep = document.getElementById("cepDoarRoupa");
    const rua = document.getElementById("ruaDoarRoupa");
    const bairro = document.getElementById("bairroDoarRoupa");
    const cidade = document.getElementById("cidadeDoarRoupa");
    const uf = document.getElementById("ufDoarRoupa");

    pesquisa_cep(cep, rua, bairro, cidade, uf);
}