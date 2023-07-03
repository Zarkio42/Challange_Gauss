const previousOpText = document.querySelector('#previous-operation');
const currentOpText = document.querySelector('#current-operation');
const button = document.querySelectorAll(".btn");

class Calculator {
    constructor(previousOpText, currentOpText) {
        this.previousOpText = previousOpText;
        this.currentOpText = currentOpText;
        this.currentOperation = "";
    }

    //add digit to calculator screen
    addDigit(digit) {

        //check if current op. already has a dot
        if (digit === "." && this.currentOpText.innerText.includes(".")) {
            return;
        }
        this.currentOperation = digit;
        this.updateScreen();
    }

    //Process all calculator op.

    processOperation(operation) {

        //check if current is empty
        if (this.currentOpText.innerText === "" && operation !== "C") {
            if (this.previousOpText.innerText !== "") {
                //change operation
                this.changeOperation(operation);
            }
            return;
        }

        //get current and previous value
        let operationValue;
        let previous = +this.previousOpText.innerText.split(" ")[0];
        let current = +this.currentOpText.innerText;

        switch (operation) {
            case "+":
                operationValue = previous + current;
                this.updateScreen(operationValue, operation, current, previous);
                break;

            case "-":
                operationValue = previous - current;
                this.updateScreen(operationValue, operation, current, previous);
                break;

            case "X": 
            case "*":
                operationValue = previous * current;
                this.updateScreen(operationValue, operation, current, previous);
                break;

            case "/":
                operationValue = previous / current;
                this.updateScreen(operationValue, operation, current, previous);
                break;

            case "DEL":
                this.processDelOperator();
                break;

            case "CE":
                this.processClearCurrentOp();
                break;

            case "C":
                this.processClearAll();
                break;
            
            case "=":
                this.processEqualOp();
                break;

            default:
                return;
        }

    }

    //change values of the calculator screen
    updateScreen(operationValue = null, operation = null, current = null, previous = null) {
        if (operationValue === null) {
            this.currentOpText.innerText += this.currentOperation;
        }
        else {
            //check if value is zero, if it is just add current value
            if (previous === 0) {
                operationValue = current;
            }

            //transform 'x' to '*'
            if (operation === "X" || operation === "*") {
                operation = "*";
            }

            //add current value to previous
            this.previousOpText.innerText = `${operationValue} ${operation}`;
            this.currentOpText.innerText = "";
        }
    }

    //change math op.
    changeOperation(operation) {

        const mathOperations = ["+", "-", "/", "X"];

        if (!mathOperations.includes(operation)) {
            return;
        }

        //transform 'x' to '*'
        if (operation === "X" || operation === "*") {
            operation = "*";
        }

        this.previousOpText.innerText = this.previousOpText.innerText.slice(0, -1) + operation;

    }

    //Delete the last digit
    processDelOperator() {
        this.currentOpText.innerText = this.currentOpText.innerText.slice(0, -1);
    }

    //Clear current field
    processClearCurrentOp(){
        this.currentOpText.innerText="";
    }

    //Clear current and previous field
    processClearAll(){
        this.currentOpText.innerText = "";
        this.previousOpText.innerText = "";
    }

    //process an operation
    processEqualOp(){
        const operation = previousOpText.innerText.split(" ")[1];
        this.processOperation(operation);
    }
}

const calc = new Calculator(previousOpText, currentOpText);

button.forEach((btn) => {
    btn.addEventListener("click", (e) => {
        const value = e.target.innerText;

        if (+value >= 0 || value === ".") {
            calc.addDigit(value);
        }
        else {
            calc.processOperation(value);
        }
    });
});


