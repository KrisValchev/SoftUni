function solve(symbol1, symbol2) {
    let firstChar = symbol1.charCodeAt();
    let secondChar = symbol2.charCodeAt();
    let array = [];
    let stratIndex = function (firstChar, secondChar) {
        if (firstChar > secondChar) {
            return secondChar;
        } else {
            return firstChar;
        }
    }
    index = 0;
    for (let i = stratIndex(firstChar,secondChar)+1; i < stratIndex(firstChar,secondChar) + Math.abs(firstChar - secondChar); i++) {
        array[index++] = String.fromCharCode(i);
    }
console.log(array.join(' '));
}
