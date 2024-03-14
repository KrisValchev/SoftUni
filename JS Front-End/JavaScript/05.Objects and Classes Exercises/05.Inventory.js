function solve(heroes) {
let arrayOfHeroes=[];
 for (const iterator of heroes) {
    let heroInfo=iterator.split(' / ');
    let hero={
        name:heroInfo[0],
        level:heroInfo[1],
        items:heroInfo[2]
    }
    arrayOfHeroes.push(hero);
 }
 for (const hero of arrayOfHeroes.sort((x,y)=>x.level-y.level)) {
        console.log(`Hero: ${hero.name}`);
        console.log(`level => ${hero.level}`);
        console.log(`items => ${hero.items}`);
 }
}
