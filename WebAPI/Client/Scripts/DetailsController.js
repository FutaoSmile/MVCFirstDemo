(function (app) {
    var DetailsController = function ($scope, $http, $routeParams) {

        var id = $routeParams.id;
        $http.get("/api/movies/Getmovie/" + id).then(function (result) {
            $scope.movie = result.data;
        });
    };
    app.controller("DetailsController", DetailsController);

}(angular.module("atTheMovies")));