localStorage.clear();

const confirmar = () => {
    if (confirm("\nDeseja salvar seus dados de acesso?\n")) {
        save_storage();
    }
    //login
}

const save_storage = () => {
    const login = document.getElementById("login").value;
    const senha = document.getElementById("senha").value;
    localStorage.setItem("login:", `${login}`);
    localStorage.setItem("senha:", `${senha}`);
}