function solve(a, b, c) {
    let smallestNumber = min(min(a, b), c);
    console.log(smallestNumber);
    function min(a, b) {
        if (a > b) {
            return b;
        }
        else {
            return a;
        }
    }
}
