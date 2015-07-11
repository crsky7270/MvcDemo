login.controller("LoginController", function ($scope, $http, $location,$window) {
    $scope.email = "";
    $scope.password = "";
    $scope.log = function () {
        var postData = { account: $scope.email, password: $scope.password };
        var config = { params: { id: '5' } };
        $http.post('Login/UserLogin', postData)
            .success(function (data, status, headers, config) {
                if (data.status == "1")
                    $window.location.href = "/Home";
            }).error(function (data, status, headers, config) {

            });
    };
});