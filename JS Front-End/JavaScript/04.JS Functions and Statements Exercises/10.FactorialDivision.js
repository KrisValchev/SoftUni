function solve(num1,num2) {
    let sum=0;
    console.log((factorial(num1)/factorial(num2)).toFixed(2));
    function factorial(number){
        if(number===0 || number===1){
            return 1;
        }else{
            return factorial(number-1)*number;
        }
    }
}
