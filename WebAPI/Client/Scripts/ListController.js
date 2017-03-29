(function (app) {
    var ListController = function ($scope, $http) {
        $http.get("/api/movies/GetMovies").then(function (result) {
            $scope.movies = result.data;
        })
    };
    //ListController.$inject = ["$scope", "$http"];
    app.controller("ListController", ListController);
}(angular.module("atTheMovies")));