var orderData = angular.module('orderData', ['ngResource']);
orderData.controller('orderDataController', function ($scope,orders) {

    $scope.orders = [];
    orders.query(function (data) {
        $scope.orders = data;
    });
    
});
orderData.factory('orders', function ($resource) {
    
        return $resource("https://dqccomics-webapi.azurewebsites.net/api/Bookings/:id", { '$orderby': 'id asc' }, {});
    
})
