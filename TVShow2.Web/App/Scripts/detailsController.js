﻿app.controller("detailsController", function ($scope, $http, $routeParams) {
    $scope.show = {};
    $http.get("/api/v1/TvShow/" + $routeParams.id).success(function (data) {
        $scope.show = data;
    });
});