function solve(number) {
    let stringNumber = number.toString();
    let same = true;
    let sum = 0;
    for (let i = 0; i < stringNumber.length; i++) {
        sum += Number(stringNumber[i]);
        if (i !== 0 && stringNumber[i] !== stringNumber[i - 1]) {
            same = false;
        }
    }
    console.log(same);
    console.log(sum);
}
