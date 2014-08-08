var app = angular.module("app", ["ngRoute"]);
app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider.when("/", {
        templateUrl: "Views/home.html",
        controller: "homeController"
    }).when("/Details/:id", {
        templateUrl: "Views/details.html",
        controller: "detailsController"
    }).otherwise({ redirectTo: "/" })
}]);