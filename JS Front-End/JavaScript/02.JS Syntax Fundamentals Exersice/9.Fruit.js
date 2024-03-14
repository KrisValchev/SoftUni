function solve(fruit,grams,price){
    let kg=grams/1000;
    let neededPrice=kg*price;
    console.log(`I need $${neededPrice.toFixed(2)} to buy ${kg.toFixed(2)} kilograms ${fruit}.`);
}
