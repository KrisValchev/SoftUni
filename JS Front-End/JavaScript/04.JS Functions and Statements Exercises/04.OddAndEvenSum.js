function solve(number) {
    let stringNumber = number.toString();
console.log(`Odd sum = ${OddSum(stringNumber)}, Even sum = ${EvenSum(stringNumber)}`);
    function OddSum(stringNumber) {
        let sum = 0;
        for (let i = 0; i < stringNumber.length; i++) {
            if (Number(stringNumber[i]) % 2 !== 0) {
                sum += Number(stringNumber[i]);
            }
        }
        return sum;
    }
    function EvenSum(stringNumber) {
        let sum = 0;
        for (let i = 0; i < stringNumber.length; i++) {
            if (Number(stringNumber[i]) % 2 === 0) {
                sum += Number(stringNumber[i]);
            }
        }
        return sum;
    }
}
