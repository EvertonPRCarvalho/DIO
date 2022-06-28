//Promises

const doSomethingPromise = () =>
 new Promise((resove, reject) => {
    setTimeout(function(){
        //did something
        resolve('First data')
    }, 10000);
});

const doOtherThingPromise = () =>
new Promise((resolve, reject) => {
    setTimeout(function(){
        //did something
        reject('Second data')
    }, 1000);
});

Promise.all([doOtherThingPromise(), doOtherThingPromise()]).then(data => { //Promise.all([function1, function2]) Executa duas funções ao mesmo tempo.
    console.log(data[0].split(''));
    console.log(data[1].split(''));
}).catch(err => {
    console.log(err)
});

// Callbacks
function doSomething(callback){
    setTimeout(function() {
     // did somithing
     callback('First data');   
    }, 1000);
}

function doOtherThing(callback){
    setTimeout(function() {
     // did somithing
     callback('Second data');   
    }, 1000);
}

function doAll() {
    try{
        doSomething(function(data) {
            var processedData = data.split('');
            
            try{
                doOtherThing(function(data2) {
                    var processedData2 = data2.split('');
                    try{
                        setTimeout(function() {
                            console.log(processedData, processedData2);
                        }, 1000);
                    } catch(err){
                        //handle error
                    }
                });
            } catch(err){
                //handle error
            }
        });
    } catch(err){
        //handle error
    }
}
doAll()