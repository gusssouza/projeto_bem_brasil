const setCookie = (name, value, expires) => {
    var cookie = name + "=" + escape(value) + ((duration) ? "; expires=" + expires.toUTCString() + ";path=/" : "");
    document.cookie = cookie;
}

const getCookie = (name) => {
    var cookies = document.cookie;
    var prefix = name + "=";
    var begin = cookies.indexOf("; " + prefix);

    if (begin == -1) {

        begin = cookies.indexOf(prefix);

        if (begin != 0) {
            return null;
        }

    } else {
        console.log(begin);
        begin += 2;
    }

    var end = cookies.indexOf(";", begin);
    console.log(begin, end);

    if (end == -1) {
        end = cookies.length;
    }

    return unescape(cookies.substring(begin + prefix.length, end));
}


const salvar_cookies = () => {
    const login = document.getElementById("login");
    const senha = document.getElementById("senha");
    const checkbox = document.getElementById("form2Example33");
    console.log( "i")

    const date = new Date();
    const time = date.getTime();
    var expireTime = time + 1500 * 60;
    now.setTime(expireTime);

    if (checkbox.checked) {
        setCookie("login", login, now);
        setCookie("senha", senha, now);
    }

    
}