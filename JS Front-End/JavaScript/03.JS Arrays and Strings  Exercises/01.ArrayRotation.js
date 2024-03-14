function solve(array, rotations) {
    for (let i = 0; i < rotations; i++) {
        let firstElement = array.shift();
        array.push(firstElement);
    }
    console.log(array.join(' '));
}
