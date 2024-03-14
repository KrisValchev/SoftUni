function solve(number) {
    let array = [];
    makeMatrix(number,array);
    for (let i = 0; i < number; i++) {
        console.log(array.join(' '));
    }
    function makeMatrix(number, array) {
        for (let i = 0; i < number; i++) {
            array.push(number);
        }
    }

}
