var app = angular.module("app", []);
app.controller("adminControll", function($scope, $http) {
  $scope.busiData;
  $http.get("GetAllBusData").then(function(data) {
    $scope.busiData = data.data;
    console.log($scope.busiData);
  });
  $scope.DeleteData = function(event) {
    // $http.delete(`DeleteInfo/${event.currentTarget.id}`).then(
    //   function(data) {
    //     $http.get("GetAllBusData").then(function(data) {
    //       $scope.busiData = data.data;
    //     });
    //   },
    //   function(err) {}
    // );
    console.log(event);
  };
});
