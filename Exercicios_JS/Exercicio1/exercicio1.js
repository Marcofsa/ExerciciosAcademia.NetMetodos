funcion func(){
    alert(1+2);
}
funcion MinhaFunc(){
    var x = document.getElementById("nome");
    x.value = x.value.toUpperCase();
}

function mostraNomeIdade(){
    var nome = document.getElementById("nome");
    var idade = document.getElementById("idade");
}

if (idade.value >= 18){
    alert(nome.value + "é maior de idade");
}
else {
    alert(nome.value + "tem" idade.value + "anos de idade.");
}