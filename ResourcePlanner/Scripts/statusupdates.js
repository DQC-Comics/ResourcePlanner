var resourceHubProxy = $.connection.bookingsHub;
resourceHubProxy.client.bookingStatus = function (bookingId, status) {

    $('#statusUpdate')[0].innerText = '"Booking with id ' + bookingId + ' is now ' + status + '"';
    $('#statusUpdate').fadeIn(300).fadeOut(300).fadeIn(500).fadeOut(500).fadeIn(1000);
};

$.connection.hub.url = "https://dqccomics-webapi.azurewebsites.net/signalR";
$.connection.hub.start()
    .done(function () { console.log('Now connected, connection ID=' + $.connection.hub.id); })
    .fail(function () { console.log('Could not Connect!') });