function solve(string) {
    let array = [];
    array = string.match(/[A-Z][a-z]*/gm);
    console.log(array.join(', '));
}
