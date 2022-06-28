var arr = ['Aplle', 'Banana', 'Orange'];
var apple = arr[0];
var banana = arr[1];
var orange = arr[2];

var [Aplle1, Banana2, Orange2, [Tomato2]] = ['Aplle', 'Banana', 'Orange', ['Tomato']];

console.log(Tomato2);

var obj = {
    name:  'celso'
};
var {name: nome2} = obj;

console.log(nome2);