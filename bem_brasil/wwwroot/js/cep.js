const limpa_formulario = () => {

    document.getElementById('rua').value = ("");
    document.getElementById('bairro').value = ("");
    document.getElementById('cidade').value = ("");
    document.getElementById('UF').value = ("");
}

const complete = (conteudo) => {
    if (!("erro" in conteudo)) {

        document.getElementById('rua').value = (conteudo.logradouro);
        document.getElementById('bairro').value = (conteudo.bairro);
        document.getElementById('cidade').value = (conteudo.localidade);
        document.getElementById('UF').value = (conteudo.uf);
    }
    else {

        limpa_formulario();
        alert("CEP não encontrado.");
    }
}

const pesquisa_cep = (cep) => {
    if (cep != "") {
        var validacep = /^[0-9]{8}$/;

        if (validacep.test(cep)) {

        }
        else {
            limpa_formulario();
            alert("Formato de CEP inválido");
        }
    }
    else {
        limpa_formulario();
    }
}