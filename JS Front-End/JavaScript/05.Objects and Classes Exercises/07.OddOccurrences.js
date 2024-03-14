function solve(text) {
    let arrayOfStrings = text.split(' ').map(x=>x.toLowerCase());
    let words = [];
    for (const iterator of arrayOfStrings) {
        if (!words.some(x => x.name === iterator)) {
            words.push({
                name: iterator,
                count: arrayOfStrings.filter(x => x === iterator).length
            });
        }
    }
    let odd=[];
    for (const iterator of words.filter(x=>x.count%2!==0)) {
       odd.push(iterator.name);
    }
    console.log(odd.join(' '));
}
