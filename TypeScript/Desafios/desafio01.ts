// DESAFIO 1 Como podemos rodar isso em um arquivo .ts sem causar erros? 
//Resposta 01
type Employee = {
    code: number,
    name: string
};
const employee1: Employee = { 
    code: 10,
    name: "John"
}
//Resposta 02
const employee2 = {
    code: 10,
    name: "John"

}

console.log('Arquivo de testes. Pode mexer nele como quiser.');