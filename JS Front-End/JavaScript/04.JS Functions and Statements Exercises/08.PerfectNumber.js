function solve(number) {
    let array = findDivisiors(number);
    let sum = sumArray(array);
     if(sum===number){
        console.log('We have a perfect number!');
     }else{
        console.log(`It's not so perfect.`);
     }
    function findDivisiors(number) {
        let array = [];
        for (let i = 1; i <= number / 2; i++) {
            if (number % i === 0) {
                array.push(i);
            }
        }
        return array;
    }
    function sumArray(array) {
        let sum=0;
        for (let i = 0; i < array.length; i++) {
            sum += array[i];
        }
        return sum;
    }
}
