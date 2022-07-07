//FUNCAO
const soma = function (a, b) {
    return a + b;
}

//FUNCAO AUTOINVOCAVEL (IIFE)

var resultado  = (
    function(){
        let name = "Digital Innovation One";
        return name;
    }
)();
resultado;

//CALLBACKS
const calc = function (operacao, a, b){
    return operacao(a,b);
}
const sum = function(a,b){
    return a+b;
}

const sub = function(a,b){
    return a-b;
}

const resultSoma = calc(soma, 1, 2);
const resultSub = calc(sub, 1, 2);

console.log(resultSoma);
console.log(resultSub);

//OBJETO ARGUMENTS
function showArgs(){
    return arguments;
}
console.log(showArgs(1,2,[3,4,5], "seis"));

//ARRAYS E OBJETOS
//Spread: uma forma de lidar separadamente com elementos
function sum2(x, y, z){
    return x+y+z;
}

console.log("Spread");
const numbers = [1,2,3];
console.log(sum2(...numbers));

//Rest: combina os argumentos em um array
function confereTamanho(...args){
    console.log("Tamanho = " + args.length);
}
console.log("Reste");
confereTamanho();
confereTamanho(1,2);
confereTamanho(1,2,3);

//OBJETOS
//Object Desctructuring
const user = {
    id: 13,
    displayName: 'ecarvalho',
    fullName:{
        firstName: 'Everton',
        lastName: 'Carvalho'
    }
};
function userId({id}){
    return id;
}

function getFullName({fullName:{firstName:first, lastName:last}}){
    return `${first} ${last}`;
}

console.log("Object Desctructuring");
console.log(userId(user));
console.log(getFullName(user));

//FOR..IN
//Loop entre propriedades enumeráveis de um objeto.
function forInObjeto(obj){
    for(prop in obj){
        console.log(prop);
    }
}
function forInObjeto1(obj){
    for(prop in obj){
        console.log(obj[prop]);
    }
}

const meuObjeto = {
    nome: "Everton",
    idade: 23,
    cidade: "Prince Albert"
}
console.log("\nfor...in\nReturna Propriedade");
forInObjeto(meuObjeto);
console.log("\nfor...in\nReturna o Valor da Propriedade");
forInObjeto1(meuObjeto);


//FOR..OF
//Loop entre estruturas iteráveis (arrays, strings).
function logLetras(palavra){
    for(letra of palavra){
        console.log(letra);
    }
}

const palavra = "Malcolm X";

console.log("FOR...OF");
logLetras(palavra);

//THIS
//É uma referência de contexto.
const pessoa = {
    firstName: 'Everton',
    lastName : 'Carvalho',
    id       : 13,
    fullName : function(){
        return `${this.firstName} ${this.lastName}`
    },
    getId    :function(){
        return this.id;
    }
}
console.log("\nTHIS");
console.log(pessoa.fullName());
console.log(pessoa.getId());

//Método CALL
const pessoa1 = {
    nome: 'Everton'
};

const animal = {
    nome: 'Girassol'
}

function getSomething(){
    //Dessa forma o this não referencia nenhum objeto.
    console.log(this.nome);
}
console.log("\nMétodo CALL");
//Já aqui, com o método CALL o this passa a referenciar o objeto pessoa1.
getSomething.call(pessoa1);
getSomething.call(animal);
//Similarmente:
const myObject = {
    num1: 2,
    num2: 4
};
function soma2(a, b){
    console.log(this.num1 + this.num2 + a + b);
}
soma2.call(myObject,1,5);

//FUNCAO APPLY
const pessoa3 = {
    nome: 'Saira'
};
const animal3 = {
    nome: 'Antonela'
};
console.log("\nFunção APLLAY")
getSomething.apply(pessoa3);
getSomething.apply(animal3);

const myObject2 = {
    num1: 2,
    num2: 4
};
function soma2(a, b){
    console.log(this.num1 + this.num2 + a + b);
}
soma2.apply(myObject2,[1,5]);


//BIND
//Clona a estrutura da função onde é chamada e aplica o valor do objeto passado como parâmetro.
const retornaNomes = function(){
    return this.nome;
};
let artur = retornaNomes.bind({nome:'Artur'}); //Dessa forma, com uso do BIND, a variável 'artur' torna-se uma função.

console.log("\nBIND");
console.log(artur()); //E, tal como uma função, deve ser invocada dessa forma 'artur()'

//ARROW FUNCTIONS
//Arrow Functions não faz hoisting!
//Não deve ser usada como método.
let soma3 = (a, b) => a + b;
console.log("\nArrow Functions")
console.log(soma3(6,4));