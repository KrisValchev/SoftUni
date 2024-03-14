function solve(array){
    for(let i=0;i<array.length;i++){
        console.log(IsPalindrome(array[i]));
    }

    function IsPalindrome(number){
        let forwardNumber=number.toString();
        let backwardNumber=forwardNumber.split('').reverse().join('');
        return forwardNumber===backwardNumber;
    }
}
