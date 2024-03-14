function solve(array) {
    const parking={};
    for(const row of array){
        const [direction,carNumber] =row.split(', ');
        direction==='IN'
        ? parking[carNumber]=true
        :delete parking[carNumber]
    }
    Object.keys(parking)
    .sort((a,b)=>a.localeCompare(b))
    .forEach(carNumber =>console.log(carNumber));
}

