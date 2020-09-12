const HttpService = {};

HttpService.post = function (url, data, success) {
    $.ajax({
        url: url,
        data: data,
        success: success,
        method: 'POST',
        error: function (err) {
            alert('Unexpected error see console for details');
            console.error(err);
        }
    });
};

HttpService.get = function (url, success, cache) {
    $.ajax({
        url: url,
        success: success,
        method: 'GET',
        cache: cache || false,
        error: function (err) {
            alert('Unexpected error see console for details');
            console.error(err);
        }
    });
};
