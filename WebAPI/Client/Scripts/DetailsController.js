//(function (app) {
//    var DetailsController = function ($scope, $http, $routeParams) {

//        var id = $routeParams.id;
//        $http.get("/api/movies/Getmovie/" + id).then(function (result) {
//            $scope.movie = result.data;
//        });
//    };
//    app.controller("DetailsController", DetailsController);

//}(angular.module("atTheMovies")));
//使用自定义movieService
(function (app) {
    var DetailsController = function ($scope, $routeParams,movieService) {

        var id = $routeParams.id;
        movieService.getById(id).then(function (result) { $scope.movie = result.data; });
    };
    app.controller("DetailsController", DetailsController);

}(angular.module("atTheMovies")));