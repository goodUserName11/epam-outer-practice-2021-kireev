function simpleCalc(str) 
{
    let operatorsPattern = /[\+,\-,\*,\/,\=]/ig;  
    let operatorArr = str.match(operatorsPattern);
    console.log(operatorArr);
    
    let operandsPattern = /\d+(\.\d+)?/ig;
    let operandArr = str.match(operandsPattern);
    console.log(operandArr);

    if(operandArr.length <= 0 || operatorArr.length <= 0) {
        console.log("there is no operands or operators");
        return 0;
    }

    if(operandArr.length != operatorArr.length) {
        console.log("incorrect math expression");
        return 0;
    }
    
    let a = Number(operandArr[0]);
    let b = Number.NaN;

    for(let i = 0; i < operatorArr.length; i++) {
        switch (operatorArr[i]) {
            case "+":
                b = Number(operandArr[i+1]);
                a += b;
                break;
            
            case "-":
                b = Number(operandArr[i+1]);
                a -= b;
                break;
                
            case "*":
                b = Number(operandArr[i+1]);
                a *= b;
                break;
            
            case "/":
                b = Number(operandArr[i+1]);
                a /= b;
                break;
                
            case "=":
                return a.toFixed(2);

            default:
                console.log("incorrect math expression")
                return 0;
        } 
    }

    console.log("error occured")
        return 0;     
}