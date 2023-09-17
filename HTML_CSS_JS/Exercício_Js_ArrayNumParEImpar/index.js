const numeros = [1,2,3,4,5,6,7,8,9];
const numPares = [];
const numImpares = [];

function GetNumeros (){

    

    for(let i = 0; i < numeros.length; i++){

        if (numeros[i]%2 === 0){
            
            numPares.push(numeros[i])
        }

        else{
            numImpares.push(numeros[i])
        } 
    }
        console.log("Numeros Pares: ", numPares)
        console.log("Numeros Ímpares: ", numImpares)
    
}

GetNumeros();