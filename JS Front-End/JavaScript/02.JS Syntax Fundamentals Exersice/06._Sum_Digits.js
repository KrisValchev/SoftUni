function solve(number) {
    let stringNumber = number.toString();
    let sum = 0;
    for (let i = 0; i < stringNumber.length; i++) {
        sum += Number(stringNumber[i]);
    }
    console.log(sum);
}
