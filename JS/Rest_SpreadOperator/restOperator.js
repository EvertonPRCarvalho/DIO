function sum1(...args) {
    value = 0;
    for (i=0; i < args.length; i++){
        value += args[i]
    };
return value;
};

function sum2(...args){
    return args.reduce((acc, value) => acc + value, 0);
}

const multuply = (...args) => args.reduce((acc, value) => acc * value, 1);
const sum3 = (...rest) => { return multuply(...rest);
};
//console.log(sum3(5,6,3,2,2));

const str = "Digital innovation One";
function logArgs(...args){
    console.log(args);
};
logArgs(...str);