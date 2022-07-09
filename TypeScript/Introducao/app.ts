const pessoa = {
    nome: 'Maria',
    idade: 28,
    profissao: 'Desenvolvedora'
}
const andre: {nome: string, idade: number, profissao: string} = {
    nome: 'Andre',
    idade: 25,
    profissao: 'Motorista'
}

pessoa.idade = 28;

enum Profissao {
    Professora,
    Atriz,
    Desenvolvedora,
    JogadoraDeFutebol
}

interface Pessoa {
    nome: string,
    idade: number,
    profissao?: Profissao//Uma pessoa pode ou não ter profissão.
}

interface Estudante extends Pessoa{
    materias: string[];
}

const jessica: Estudante = {
    nome: 'Jessica',
    idade: 22,
    materias: ['Matemática Discreta', 'Programação'],
    profissao: Profissao.Desenvolvedora
}
const Ada: Pessoa = {
    nome: 'Pedro',
    idade: 23,
    profissao: Profissao.Desenvolvedora
}

//Criar tipos
type input = number | string; //'input' pode ser tando number quanto string.
function soma(input1: input, input2:input){
    if(typeof input1 == 'string' || typeof input2 == 'string'){
        return input1.toString() + input2.toString();
    }else {
        return input1 + input2;
    }
}

//Definir o tipo de retorno de uma função
function somarDoisNumeros(a: number, b: number): number{
    return a + b;
}

//Callback
function somarDoisNumeros3(a: number, b: number, callback: (numero: number) => number): number{
    let resultado = a + b;
    return callback(resultado);
}

function aoQuadrado(numero: number): number {
    return numero*numero;
}
console.log(somarDoisNumeros3(1, 3, aoQuadrado));
//16
