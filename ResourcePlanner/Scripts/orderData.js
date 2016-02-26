var orderData = angular.module('orderData');
orderData.controller('orderDataController', function ($scope, orders) {

    $scope.orders = [];
    
    function populateOrders() {
        var url = "https://dqccomics-webapi.azurewebsites.net/api/Bookings";
        $.ajax({
            url: url,
            data: data,
            headers: "application/json",
            success: function (odata) {
                console.log(odata)
            },
            fail: function (oData) {

            }
        })
    }
    $(document).ready(function () {
        console.log("Test")
        populateOrders
    })
})
