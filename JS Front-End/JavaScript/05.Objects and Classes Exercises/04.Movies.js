function solve(commands) {
    let arrayOfMovies = [];
    for (const iterator of commands) {
        let command = [];
        if (iterator.includes('directedBy')) {
            command = iterator.split(' directedBy ');
            directedBy(arrayOfMovies, command[0], command[1]);
        } else if (iterator.includes('onDate')) {
            command = iterator.split(' onDate ');
            onDate(arrayOfMovies, command[0], command[1]);
        } else {
            command = iterator.split('addMovie ');
            addMovie(arrayOfMovies, command[1]);
        }
    }
    for (const movie of arrayOfMovies) {
        if (movie.director !== undefined && movie.date !== undefined) {
            console.log(JSON.stringify(movie));
        }
    }

    function addMovie(arrayOfMovies, movie) {
        arrayOfMovies.push({name:movie})
    }
    function directedBy(arrayOfMovies, movie, director) {
        let existingMovie = arrayOfMovies.find(x => x.name === movie);
        if (existingMovie !== undefined) {
            existingMovie['director'] = director;
        }
    }
    function onDate(arrayOfMovies, movie, date) {
        let existingMovie = arrayOfMovies.find(x => x.name === movie);
        if (existingMovie !== undefined) {
            existingMovie['date'] = date;
        }
    }
}
