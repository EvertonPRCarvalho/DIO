// Como podemos melhorar o esse código usando TS? 

interface PessoaUnica {
    nome: string,
    idade: number,
    profissao?: string
}
let pessoa1 = {
    nome: "maria",
    idade: 29,
    profissao: "atriz"

};

const pessoa2 : PessoaUnica = {
    nome: "roberto",
    idade: 19,
    profissao: "Padeiro"
}

let pessoa3 = {
    nome: "laura",
    idade: "32",
    profissao: "Atriz"
};

let pessoa4 = {
    nome: "carlos",
    idade: 19,
    profissao: "padeiro"
}