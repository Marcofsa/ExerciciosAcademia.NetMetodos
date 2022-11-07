function changeBackground(tipo) {
  if (tipo === "RD") {
    document.body.style.background = "RED";
  }

  if (tipo === "GR") {
    document.body.style.background = "GREEN";
  }

  if (tipo === "BL") {
    document.body.style.background = "BLUE";
  }
  if (tipo === "YL") {
    document.body.style.background = "YELLOW";
  }
  if (tipo === "PD") {
    document.body.style.background = "";
  }
}

function mostraOculta(botao, texto) {
  var estado = document.getElementById(texto).style.display;
  if (estado === "none") {
    document.getElementById(texto).style.display = "block";
    document.getElementById(botao).innerHTML = "Ocultar Texto";
    document.getElementById(botao).className = "btnRED";
  } else {
    document.getElementById(texto).style.display = "none";
    document.getElementById(botao).innerHTML = "Exibir Texto";
    document.getElementById(botao).className = "btnBLUE";
  }
}

function verificaChecks() {
  const op1 = document.getElementById("opcao1");
  const op2 = document.getElementById("opcao2");
  const op3 = document.getElementById("opcao3");
  const op4 = document.getElementById("opcao4");
  const op5 = document.getElementById("opcao5");
  const btn = document.getElementById("ex5Btn");
  var checks = 0;

  if (op1.checked) {
    checks++;
  }
  if (op2.checked) {
    checks++;
  }
  if (op3.checked) {
    checks++;
  }
  if (op4.checked) {
    checks++;
  }
  if (op5.checked) {
    checks++;
  }

  if (checks > 1) {
    btn.disabled = false;
  } else {
    btn.disabled = true;
  }
}

function mudaCorParagrafo(tipo, cor) {
  const paragrafo = document.getElementById("texto");

  if (tipo === "texto") {
    if (cor === "branco") {
      paragrafo.style.color = "white";
    }

    if (cor === "preto") {
      paragrafo.style.color = "black";
    }
  } else if (tipo === "fundo") {
    if (cor === "branco") {
      paragrafo.style.backgroundColor = "white";
    }
    if (cor === "preto") {
      paragrafo.style.backgroundColor = "black";
    }
  }
}

function zoomTexto(sinal) {
  const paragrafo = document.getElementById("texto");
  const pFonte = document.getElementById("fonte");
  var fonte = paragrafo.style.fontSize;

  fonte = fonte.replace("px", "");
  fonte = parseInt(fonte);

  if (sinal === "+") {
    fonte += 2;
    pFonte.style.fontSize = fonte + "px";
    pFonte.innerHTML = "Fonte: " + fonte + "px";
    paragrafo.style.fontSize = fonte + "px";
  }
  if (sinal === "-") {
    fonte -= 2;
    pFonte.style.fontSize = fonte + "px";
    pFonte.innerHTML = "Fonte: " + fonte + "px";
    paragrafo.style.fontSize = fonte + "px";
  }
}

function TransformaTexto(sinal) {
  const paragrafo = document.getElementById("texto");

  if (sinal === "+") {
    paragrafo.style = "text-transform: uppercase";
  }
  if (sinal === "-") {
    paragrafo.style = "text-transform: lowercase";
  }
}

function validaLogin() {
  const login = document.getElementById("login");
  const senha = document.getElementById("senha");
  const confSenha = document.getElementById("confirmaSenha");
  const botao = document.getElementById("enviar");

  if (login.value.length < 4) {
    alert("O campo login deve possuir ao menos 4 caracteres");
    login.value = "";
    login.focus();
    botao.disabled = true;
    return false;
  }

  if (senha.value !== confSenha.value) {
    alert("As senhas não são iguais.");
    botao.disabled = true;
    return false;
  }

  if (
    (senha.value.length < 6 || senha.value.length > 10) &&
    (confSenha.value.length < 6 || confSenha.value.length > 10)
  ) {
    alert("A senha deve ter de 6 a 10 caracteres.");
    botao.disabled = true;
    return false;
  } else {
    botao.disabled = false;
    return true;
  }
}

function tipoPessoa(tipo) {
  const cpf = document.getElementById("cpf");
  const cnpj = document.getElementById("cnpj");
  const dataNascimento = document.getElementById("dataNascimento");
  if (tipo === "pf") {
    cpf.disabled = false;
    cnpj.disabled = true;
    cnpj.value = "";
    dataNascimento.disabled = false;
  }
  if (tipo === "pj") {
    cpf.disabled = true;
    cpf.value = "";
    cnpj.disabled = false;
    dataNascimento.disabled = true;
  }
}
