var currentNumberWrapper = document.getElementById("currentNumber");
var currentNumber = 0;

function colored(x){
    if(x < 0){
        document.getElementById("currentNumber").style.color = "red";
    }else if(x > 0){
        document.getElementById("currentNumber").style.color = "green";
    }else if(x === 0){
        document.getElementById("currentNumber").style.color = "lightgray";
    }
}

function verify(x){
    if(x < 0){
        var temp = x * (-1);
        if((temp%2) === 0 ){
            document.getElementById("imparPar").innerHTML = "|X| Par";
        }else if((temp%2) === 1 ){
            document.getElementById("imparPar").innerHTML = "|X| Impar";
        }
    }else if((x%2) === 0 ){
        document.getElementById("imparPar").innerHTML = "Par";
    }else if((x%2) === 1 ){
        document.getElementById("imparPar").innerHTML = "Impar";
    }
}
function increment(){
    currentNumber++;
    colored(currentNumber);
    verify(currentNumber);
    currentNumberWrapper.innerHTML = currentNumber;
}

function decrement(){
    currentNumber--;
    colored(currentNumber);
    verify(currentNumber);
    currentNumberWrapper.innerHTML = currentNumber;
}