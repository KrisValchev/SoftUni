function solve(array, step) {
    let newArray=[];
    let index=0;
    for (let i = 0; i < array.length; i+=step) {
        newArray[index++]=array[i];
    }
   return newArray;
}
