app.controller("homeController", ["$scope", "$http", function ($scope, $http) {

    $scope.players = [];
    
    $http.get("/api/players")
        .then(function (result) {
            $scope.players = result.data;
        });
}]);