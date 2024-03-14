function solve(strings, text) {
    let pattern = /[\*]+/;
    let arrayOfString = strings.split(', ');
    for (let i = 0; i < arrayOfString.length; i++) {

        text = text.replace(pattern, arrayOfString.find(x=>x.length===text.match(pattern)[0].length));
    }
    console.log(text);
}
