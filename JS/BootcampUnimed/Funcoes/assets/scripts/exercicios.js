console.log("==== EXERCÍCIO 01 ====");
function getPrimeiroNome({fullName:{nome:primeiroNome}}){
    return primeiroNome;
}
function media(alunos=[], media){
    let aprovados = [];
    for(aluno of alunos){
        if(aluno.media >= media){
            aprovados.push(aluno);
            console.log(`${getPrimeiroNome(aluno)}--Situação: APROVADO!`);
        } else if (aluno.media >= 4 && aluno.media < media){
            console.log(`${getPrimeiroNome(aluno)}--Situação: RECUPERAÇÃO!`);
        } else{
            console.log(`${getPrimeiroNome(aluno)}--Situação: REPROVADO!`);
        }
    }
    console.log(aprovados);
}

let alunos = [
    {fullName: {nome:"Everton", sobrenome:"Carvalho"}, media: 8},
    {fullName: {nome:"Pedro", sobrenome:"Silva"}, media: 10},
    {fullName: {nome:"Evaristo", sobrenome:"Sousa"}, media: 4},
    {fullName: {nome:"Felipe", sobrenome:"Amado"}, media: 2},
]
media(alunos, 7);

console.log("==== EXERCÍCIO 02 ====");
function calculaIdade(anos) {
	return `Daqui a ${anos} anos, ${this.nome} terá ${
		this.idade + anos
	} anos de idade.`;
}

let pessoa = {
    nome: "Machado",
    idade: 69
}

console.log(calculaIdade.call(pessoa, 5));
console.log(calculaIdade.apply(pessoa, [5]));

let diasT = 200;
let hExtra = 100;

let temp =
console.log(((diasT > 199) && (hExtra>100)));
