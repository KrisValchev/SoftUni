function solve(text){
let pattern=/#([A-Za-z]+)/ig;
let array=text.match(pattern);
console.log(array.map(x=>x.replace('#','')).join('\n'));
}
