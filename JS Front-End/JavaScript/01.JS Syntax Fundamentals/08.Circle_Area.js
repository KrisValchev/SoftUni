function solve(number) {
    let result;
    if (typeof (number) ==='number' ) {
        result=(number**2*Math.PI).toFixed(2);
    } else {
        result = `We can not calculate the circle area, because we receive a ${typeof (number)}.`;
    }
    console.log(result);
}
