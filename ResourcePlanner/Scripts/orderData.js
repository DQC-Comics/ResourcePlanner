var orderData = angular.module('orderData', ['ngResource']);
orderData.controller('orderDataController', function ($scope,orders) {

    $scope.orders = [];
    orders.query(function (data) {
        $scope.orders = data;
    });
    $scope.openMap = function (coords) {
        console.log("Coooords")
       
    
    }
    $scope.pushNotice = function (orderIndex) {
        console.log("Clicked")
        console.log(orderIndex)
        $scope.orders[orderIndex].Status = "Confirmed"
        $scope.orders[orderIndex].$update(function () {
            console.log("Item  updated")
        })
    }
    
});
orderData.factory('orders', function ($resource) {

    return $resource("https://dqccomics-webapi.azurewebsites.net/api/Bookings/:id", { id: '@Id' }, {
        update: {
            method: 'PUT' // this method issues a PUT request
        }
        });

});


