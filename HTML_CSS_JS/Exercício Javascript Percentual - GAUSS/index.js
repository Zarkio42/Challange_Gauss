const num = [-1, -5, 0, 2, 7, 12, 100000, -4]

function calculaPercentual() {

    let numPositivos = []
    let numZero = []
    let numNegativos = []

    for (let i = 0; i < num.length; i++) {
        if (num[i] > 0) {
            numPositivos.push(num[i])
        }

        else if (num[i] < 0) {
            numNegativos.push(num[i])
        }

        else if (num[i] == 0) {
            numZero.push(num[i])
        }
    }
    
    console.log("N. Positivos =" + numPositivos)
    console.log("N. Negativos =" + numNegativos)
    console.log("N. Zero =" + numZero)

    console.log(`${(numPositivos.length / num.length).toFixed(2) * 100}%`)
    console.log(`${(numNegativos.length / num.length).toFixed(2) * 100}%`)
    console.log(`${(numZero.length / num.length).toFixed(2) * 100}%`)

}

calculaPercentual()