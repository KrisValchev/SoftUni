function solve(number, cmd1, cmd2, cmd3, cmd4, cmd5) {
    let startingPoint = number.toString();
    let commands = [cmd1, cmd2, cmd3, cmd4, cmd5 ];
    for (let i = 0; i < commands.length; i++) {
        switch (commands[i]) {
            case 'chop':
                startingPoint /= 2;
                break;
            case 'dice':
                startingPoint=Math.sqrt(startingPoint);
                break;
            case 'spice':
                startingPoint += 1;
                break;
            case 'bake':
                startingPoint *= 3;
                break;
            case 'fillet':
                startingPoint *= 0.8;
                break;
        }
        console.log(startingPoint);
    }
    
}