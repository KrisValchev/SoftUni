function solve(number) {
    let numberOfPercentages = number / 10;
    let array=loadingScreen(numberOfPercentages);
    if(number!=100){
        console.log(`${number}% [${array.join('')}]`);
        console.log(`Still loading...`);
    }
    else{
        console.log(`${number}% Complete!`);
        console.log(`[${array.join('')}]`);
    }
    function loadingScreen(numberOfPercentages) {
        let array=[];
        for(let i=0;i<numberOfPercentages;i++){
            array.push('%');
        }
        for(let i=0;i<10-numberOfPercentages;i++){
            array.push('.');
        }
        return array;
    }
}
