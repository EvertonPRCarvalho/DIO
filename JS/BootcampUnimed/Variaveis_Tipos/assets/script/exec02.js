//SEGUNDO EXERCICIO - Substituindo números pares
function paresZero(numeros){
    if (!numeros) return -1;
    if (!numeros.length) return -1;
    for (let i = 0; i < numeros.length; i++){
        if(numeros[i] === 0){
            console.log("Você já é zero!")
        }else if(numeros[i]%2 === 0){
            console.log(`Substituindo ${numeros[i]} por 0...`);
            numeros[i] = 0;
        }
    }
    return numeros;
}
arrayNum = null;

console.log(paresZero(arrayNum));