function solve(array) {
    let objects = {};
    for (const iterator of array) {
        let originalObject = JSON.parse(iterator);
        objects={...objects,...originalObject};
    }
    let sortedKeys = Object.keys(objects).sort();
    sortedKeys.forEach(key =>
        console.log(`Term: ${key} => Definition: ${objects[key]}`));
    }
