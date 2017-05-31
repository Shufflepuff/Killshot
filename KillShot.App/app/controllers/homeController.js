app.controller("homeController", ["$scope", "$http", function ($scope, $http) {

    $scope.players = [];

    $http.get("/api/players")
        .then(function (result) {
            $scope.players = result.data;
        });

    $scope.AddPoint = function (playerId) {
        $http.put(`/api/players/${playerId}`)
            .then(function (result) {
                console.log("result: ", result);
            });
    };

    console.log("$", $scope.players);
}]);