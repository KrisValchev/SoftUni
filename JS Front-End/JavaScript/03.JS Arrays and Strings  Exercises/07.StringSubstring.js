function solve(word, text) {
    let array = text.split(' ');
    for (let i = 0; i < array.length; i++) {
        if (word === array[i].toLowerCase()) {
            return console.log(word);
        }
    }
    return console.log(`${word} not found!`);
}