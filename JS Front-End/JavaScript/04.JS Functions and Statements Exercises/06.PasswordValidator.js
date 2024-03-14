function solve(pw) {
    if (!correctLength(pw)) {
        console.log('Password must be between 6 and 10 characters');
    } if (!isConsistOfLettersAndDigits(pw)) {
        console.log('Password must consist only of letters and digits');
    } if (!haveAtleast2Digits(pw)) {
        console.log('Password must have at least 2 digits');
    }
    if (correctLength(pw) && isConsistOfLettersAndDigits(pw) && haveAtleast2Digits(pw)) {
        console.log('Password is valid');
    }

    function correctLength(pw) {
        if (pw.length < 6 || pw.length > 10) {
            return false;
        }
        return true;
    }
    function isConsistOfLettersAndDigits(pw) {
        let pattern = /^[A-Za-z0-9]+$/;
        if (!pw.match(pattern)) {
            return false;
        }
        return true;
    }
    function haveAtleast2Digits(pw) {
        let pattern = /[0-9]/g;
        if (pw.match(pattern) !== null) {
            if (pw.match(pattern).length < 2) {
                return false;
            }
            return true;
        } else {
            return false;
        }
    }
}
