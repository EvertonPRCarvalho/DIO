const uniqueId1 = Symbol('Hello!');
const uniqueId2 = Symbol('Hello!');

const arr = [1,2,3,4];
const str = ['Digital Innovation One']
const i2 = arr[Symbol.iterator]();
const arr2 = [...arr, ...str]; //Exemplo de Spread Operator

///console.log(arr2);

const obj = {
    values: [1,2,3,4],
    [Symbol.iterator]() {
        let i = 0;

        return {
            next: () => {
                i++;

                return {
                    value: this.values[i - 1],
                    done: i > this.values.length
                };
            }
        };
    }
};

const it2 = obj[Symbol.iterator]();
/*
console.log(it.next());
console.log(it.next());
console.log(it.next());
console.log(it.next());
console.log(it.next());
*/
//Generation 

function* hello(){
    console.log('Hello');
    yield;               //Pausa a função até que ela seja invocada novamente, iniciando a partir da próxima linha.
    console.log('From');
    yield;               //Deve-se utilizar * após a palavra reservada function para que o yield seja executado corretamente.
    console.log('Function');
    
};
//const it = hello();

//console.log(it.next());
//console.log(it.next());

function* naturalNumber() { //Desta forma a função poderá ser invocada infinitamente ao longo do desenvolvimento do código.
    let number = 0;
    while (true) {
        yield number;
        number++;
    }
}

const it = naturalNumber();
console.log(it.next());
console.log(it.next());
console.log(it.next());
console.log(it.next());
console.log(it.next());
console.log(it.next());
console.log(it.next());

