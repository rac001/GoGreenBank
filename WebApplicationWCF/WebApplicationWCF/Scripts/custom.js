var app = angular.module('myApp', []);
app.controller('MainController', function ($scope, $http, $location, $window) {
    $scope.helloTo = {};
    $scope.helloTo.title = "World, AngularJS"; 
    
    $scope.custModel = {};
    $scope.message = '';
    $scope.result = "color-default";
    $scope.isViewLoading = false;
    $scope.ListCustomer = null;
    $scope.saveCustomer = function () {
        $scope.isViewLoading = true;

        $http({
            method: 'POST',
            url: '/Home/Insert',
            data: $scope.custModel
        }).success(function (data, status, headers, config) {
            if (data.success === true) {
                $scope.message = 'Form data Saved!';
                $scope.result = "color-green";
                //getallData();
                $scope.custModel = {};
                console.log(data);
            }
            else {
                $scope.message = 'Form data not Saved!';
                $scope.result = "color-red";
            }
        }).error(function (data, status, headers, config) {
            $scope.message = 'Unexpected Error while saving data!!' + data.errors;
            $scope.result = "color-red";
            console.log($scope.message);
        });
        getallData();
        $scope.isViewLoading = false;
    };
});  