function solve(array) {
    let word = array[0].split(' ');
    array.shift();
    let words=[];
    for (const iterator of word) {
        words.push({
            name:iterator,
            count:array.filter(x=>x===iterator).length
        });
    }
    for (const iterator of words.sort((x,y)=>y.count-x.count)) {
        console.log(iterator.name+ ' - ' + iterator.count);
    }
}
