function solve(array) {
    for (const iterator of array) {
        let info=iterator.split(' | ');
        let town=info[0];
        let latitude=Number(info[1]).toFixed(2);
        let longitude=Number(info[2]).toFixed(2);
        let townInfo={
            'town':town,
            'latitude':latitude,
            'longitude':longitude,
        }
        console.log(townInfo);
    }
}
