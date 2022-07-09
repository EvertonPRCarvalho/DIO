console.log("Estou vinculado ao index.html");

//let button = document.getElementById('button');
//let input1 = document.getElementById('input1');
//let input2 = document.getElementById('input2');

function soma(a, b){
    if (typeof a === 'number' && typeof b === 'number'){
        return (a + b);
    }else {
       return (Number(a)+Number(b));
    }
}

button.addEventListener('click', () => {
    console.log(soma(input1.value, input2.value));
})