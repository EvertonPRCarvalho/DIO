const uniqueId1 = Symbol('Hello!');
const uniqueId2 = Symbol('Hello!');

const arr = [1,2,3,4];
const str = ['Digital Innovation One']
const i2 = arr[Symbol.iterator]();
const arr2 = [...arr, ...str]; //Exemplo de Spread Operator

console.log(arr2);

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

const it = obj[Symbol.iterator]();

console.log(it.next());
console.log(it.next());
console.log(it.next());
console.log(it.next());
console.log(it.next());