var app = angular.module("KillShot", ["ngRoute"]);

app.config([
    "$routeProvider", function ($routeProvider) {
        $routeProvider
            .when("/",
            {
                templateUrl: "app/partials/Login.html",
                controller: "loginController"
            })
            .when("/home",
            {
                templateUrl: "app/partials/Home.html",
                controller: "homeController"
            })
            .when("/signup",
            {
                templateUrl: "app/partials/SignUp.html",
                controller: "signupController"
            });

    }
])

app.run(["$http", function ($http) {

    var token = sessionStorage.getItem('token');

    if (token)
        $http.defaults.headers.common['Authorization'] = `bearer ${token}`;

    }
]);