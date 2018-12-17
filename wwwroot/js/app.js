var app = angular.module("app", []);
app.controller("adminControll",function($scope,$http){

  $scope.busiData;
  $http.get("GetAllBusData").then(
    function(data){
     $scope.busiData = data.data;
     console.log($scope.busiData);
    }
  )


});