/*=====HOISTING=====*/
//EX.: 01
//numberOne = 1; 
//console.log(numberOne + 2);
//var numberOne; Pode ser declarada após a atribuição
//let numberOne; //Deve ser declarada antes da atribuição. Dessa forma apresenta um erro.

//EX.: 02
//var firstName = 'João';
//var lastName = 'Sousa';
//if(firstName === 'João'){
//    var firstName = 'Pedro'; //Trata-se de uma variável GLOBAL
//    let lastName = 'Silva'; //Trata-se de uma variável LOCAL - não é 'vista' fora desse escopo.
    //console.log(firstName, lastName);
//}

//console.log(firstName, lastName);

/*=====CONSTANTE=====*/
//FIRST_NAME = "Everton"; 
//const FIRST_NAME;          Não é possível fazer HOISTING com uma constante.
//const FIRST_NAME = "Stephany";
//const FIRST_NAME = "Maria"; Não é possível redeclarar o valor de uma constante. 
//FIRST_NAME = "Julia";       Não é possível reatribuir valor a uma constante.
//console.log(FIRST_NAME)

/*======STRING======
let nome = "João";
let sobrenome = " Pedro";
let nomeCompleto = nome.concat(sobrenome);
console.log(nomeCompleto);
nomeCompleto = `${nome}_${sobrenome}`;
console.log(nomeCompleto);

*/

//const fraseBruta = document.getElementsByClassName("frase");

function tratarFrase(fraseBruta){
    var fraseTratada = '';
    for(var x=0; x<fraseBruta.length;x++){
        if(fraseBruta[x] in ['a', 'e', 'i', 'o', 'u', 'b', 'c', 'd', 'f', 'g', 'h', 
        'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z']){
            fraseTratada += fraseBruta[x];
        }
    }
    return fraseTratada.toLowerCase();
}
function palindromo(entrada){


    var frase = tratarFrase(entrada);
    var fraseInversa = '';
    var temp = [];
    for(var e=0;e<entrada.length; e++){

        temp.unshift(entrada[e]);
    }    
    for (var t=0; t<entrada.length; t++){
        fraseInversa += temp[t];
    }
    if (entrada === fraseInversa){
        return true;
    }else{
        return false;
    }
}
//console.log(palindromo('ana'))
function resultado(){

    var container = document.getElementsByClassName("resultado");
    var textoInput = document.getElementsByClassName("frase").value;
    var resultado = document.createElement("p");
    resultado.textContent="Esta frase é um Palíndrome"
    container.appendChild(resultado);
    if(palindromo(textoInput)){
        resultado.textContent="Esta frase é um Palíndrome"
        container.appendChild(resultado);
        console.log("Esta frase é um Palíndrome");
    }else{
        resultado.textContent="Esta frase é um Palíndrome"
        container.appendChild(resultado);
        console.log("Esta frase NÃO é um Palíndrome");
    }
}

function palindromo2(string){
    if (!string) return "ERRO: String inexistente.";//Se o input for qualquer outra coisa diferente de string, retorna a mensagem de erro.

    for(let i; i < string.length / 2;i++){
        //Dado que um palíndromo é igual a outra string, basta dividir a string em 2 partes e comparar 
            //se primeira parte = segunda parte: true
            //senão primeira parte != segunda parte: false
        //Dessa maneira não é necessário que o seja executado n vezes, basta que seja executado (n / 2) vezes.
        if (string[i] !== string[string.length - 1 - i]){
            return false;
        }
    }
    return true;
}

