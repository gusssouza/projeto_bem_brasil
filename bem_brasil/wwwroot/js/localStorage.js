

document.getElementById("botaoCadastro").style.visibility = "visible";
document.getElementById("botaoLogin").style.visibility = "visible";

var logon = false;

const confirmar = () => {
    if (confirm("\nDeseja salvar seus dados de acesso?\n")) {
        save_storage();
        logon = true;
    }

    if (logon) {
        document.getElementById("botaoCadastro").style.visibility = "hidden";
        document.getElementById("botaoLogin").style.visibility = "hidden";
    } else {
        document.getElementById("botaoCadastro").style.visibility = "visible";
        document.getElementById("botaoLogin").style.visibility = "visible";
    }
    //login
}

const save_storage = () => {
    const login = document.getElementById("login").value;
    const senha = document.getElementById("senha").value;
    localStorage.setItem("login:", `${login}`);
    localStorage.setItem("senha:", `${senha}`);
}
