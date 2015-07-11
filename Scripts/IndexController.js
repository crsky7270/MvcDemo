var myApp = angular.module("first", []);

myApp.controller('MyController', function ($scope) {
    $scope.clock = {
        now: Date()
    };
    var updateClock = function () {
        $scope.clock.now = new Date();
    };
    setInterval(function () {
        $scope.$apply(updateClock);
    });
    updateClock();
});

var oper = angular.module("Oper", []);
oper.controller("OperController", function ($scope) {
    $scope.Count = 0;
    $scope.Add = function (num) {
        $scope.Count = $scope.Count + num;
    };
    $scope.Subtract = function (num) {
        $scope.Count = $scope.Count - num;
    };
});

//function MyController($scope) {
//    $scope.clock = {
//        now: Date()
//    };
//    var updateClock = function() {
//        $scope.clock.now = new Date();
//    };
//    setInterval(function () {

//        $scope.$apply(updateClock);
//    });
//    updateClock();
//}


function personController($scope) {
    $scope.person = [];
    $scope.person.name = 'Kavlez';
    $scope.person.job = 'brogrammer';
    $scope.person.sayHi = function () {
        return "Hi! I'm " + $scope.person.name + ", I'm a(an) " + $scope.person.job;
    };
}