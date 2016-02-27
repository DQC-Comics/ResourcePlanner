var orderData = angular.module('orderData', ['ngResource']);
orderData.controller('orderDataController', function ($scope,orders) {

    $scope.orders = [];
    orders.query(function (data) {
        $scope.orders = data;
    });
    $scope.pushNotice = function (orderIndex) {
        $scope.orders[orderIndex].Status = "Confirmed"
        $scope.orders[orderIndex].$update(function () {
            $.get("/Home/SendMail", { subject: $scope.orders[orderIndex].City, body: $scope.orders[orderIndex].Description });
            console.log("Item  updated")
        })
    }
   

    $scope.statusFilter = function (item) {
        if (item.Status != "Confirmed") {
            return item;
        }
        
    }
    $scope.statusFilterFalse = function (item) {
        if(item.Status === "Confirmed")
        {
            return item;
        }
    }
    
});
orderData.factory('orders', function ($resource) {

    return $resource("https://dqccomics-webapi.azurewebsites.net/api/Bookings/:id", { id: '@Id' }, {
        update: {
            method: 'PUT' // this method issues a PUT request
        }
        });

});


