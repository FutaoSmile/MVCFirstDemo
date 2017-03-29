(function (app) {
    var movieService = function ($http, movieApiUrl) {
        var getAll = function () {
            return $http.get(movieApiUrl+"getmovies");
        };
        var getById = function (ID) {
            return $http.get(movieApiUrl +"GetMovie/"+ ID);
        };
        var update = function (movie) {
            return $http.put(movieApiUrl + movie.ID, movie);
        };
        var create = function (movie) {
            return $http.post(movieApiUrl, movie);
        };
        var destroy = function (movie) {
            return $http.delete(movieApiUrl +"DeleteMovie/"+ movie.ID);
        };
        return {
            getAll: getAll,
            getById: getById,
            update: update, 
            create: create,
            delete: destroy
        };
    };
    app.factory("movieService", movieService);
}(angular.module("atTheMovies")))