function solve(containProducts, orderedProducts) {
    let arrayOfProducts = [];
    for (let i = 0; i < containProducts.length; i++) {
        let product = {
            name: containProducts[i],
            amount: Number(containProducts[++i]),
        }
        arrayOfProducts.push(product);
    }
    for (let i = 0; i < orderedProducts.length; i++) {
        let alreadyAvailable = arrayOfProducts.find(product => product.name === orderedProducts[i]);
        if (alreadyAvailable !== undefined) {
            alreadyAvailable.amount += Number(orderedProducts[++i]);
        } else {
            let product = {
                name: orderedProducts[i],
                amount: Number(orderedProducts[++i]),
            }
            arrayOfProducts.push(product);
        }
    }
    for (const product of arrayOfProducts) {
        console.log(product.name + ' -> ' + product.amount);
    }
}
