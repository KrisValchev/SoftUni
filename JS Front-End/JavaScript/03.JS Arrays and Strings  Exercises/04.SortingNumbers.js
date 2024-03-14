function solve(array) {
    array.sort((a,b)=>a-b);
    let indexEnd = array.length - 1;
    let indexStart = 0;
    let index=0;
    let newArray = [];
    while(indexEnd>=array.length/2){
        newArray[index++] = array[indexStart++];
        newArray[index++] = array[indexEnd--];
    }
    if(array.length%2!==0){
        newArray[index]=array[indexEnd];
    }
    return newArray;
}
