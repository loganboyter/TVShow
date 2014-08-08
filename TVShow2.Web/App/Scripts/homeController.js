app.controller('homeController', function ($scope, $http) {
    $scope.shows = [];
    $scope.submitShow = function () {
        $http.post("/api/v1/TvShow", $scope.newShow).success(function () {
            $scope.getShows();
        })
    }
    $scope.getShows = function () {
        $http.get("/api/v1/TvShow").success(function (data) {
            $scope.shows = data;
        });
    }
    $scope.getShows();
})