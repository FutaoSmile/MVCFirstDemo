//(function (app) {
//    var ListController = function ($scope, $http) {
//        $http.get("/api/movies/GetMovies").then(function (result) {
//            $scope.movies = result.data;
//        })
//    };
//    //ListController.$inject = ["$scope", "$http"];
//    app.controller("ListController", ListController);
//}(angular.module("atTheMovies")));

//自定义服务movieService之后的写法
(function (app) {
    var ListController = function ($scope, movieService) {
        movieService.getAll().then(function (result) { $scope.movies = result.data; });

        $scope.delete = function (movie) {

            movieService.delete(movie).then(function () { removeMovieById(movie.ID) });
        };
        //作用：当用户删除了一条数据之后，不用刷新整个页面也能使该条数据在页面删除
        var removeMovieById = function (id) {
            for (var i = 0; i < $scope.movies.length; i++) {

                if ($scope.movies[i].ID == id) {
                    $scope.movies.splice(i, 1);
                    break;
                }
            }
        }
    };
    //ListController.$inject = ["$scope", "$http"];
    app.controller("ListController", ListController);
}(angular.module("atTheMovies")));