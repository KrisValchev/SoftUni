function solve(numOfPeople, groupType, day) {
    let result;
    let price;
    let discount = 1;
    if (groupType === 'Students') {
        switch (day) {
            case 'Friday':
                price = 8.45;
                break;
            case 'Saturday':
                price = 9.80;
                break;
            case 'Sunday':
                price = 10.46;
                break;
        }
        if (numOfPeople >= 30) {
            discount = 0.85;
        }

    } else if (groupType === 'Business') {
        switch (day) {
            case 'Friday':
                price = 10.90;
                break;
            case 'Saturday':
                price = 15.60;
                break;
            case 'Sunday':
                price = 16;
                break;
        }
        if (numOfPeople > 100) {
            numOfPeople -= 10;
        }
    } else {
        switch (day) {
            case 'Friday':
                price = 15;
                break;
            case 'Saturday':
                price = 20;
                break;
            case 'Sunday':
                price = 22.50;
                break;
        }
        if (numOfPeople >= 10 && numOfPeople <= 20) {
            discount = 0.95;
        }
    }
    const totalPrice=price* numOfPeople*discount;
    result = `Total price: ${totalPrice.toFixed(2)}`;
    console.log(result);
}
