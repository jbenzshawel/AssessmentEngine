var AssessmentEngine = AssessmentEngine || {};

AssessmentEngine.HttpService = {};

AssessmentEngine.HttpService.handleError = function (err) {
    const errorMsg = 'Unexpected error see console for details';
    if ($('#ajaxAlert').length > 0)
        BootstrapUtility.alertMsg('#ajaxAlert', 'danger', errorMsg);
    else
        alert(errorMsg);
    console.error(err);
}

AssessmentEngine.HttpService.post = function (url, success) {
    $.ajax({
        url: url,
        success: success,
        method: 'POST',
        error: this.handleError
    });
};

AssessmentEngine.HttpService.postData = function (url, data, success) {
    $.ajax({
        url: url,
        success: success,
        data: data,
        method: 'POST',
        error: this.handleError
    });
};

AssessmentEngine.HttpService.get = function (url, success, cache) {
    $.ajax({
        url: url,
        success: success,
        method: 'GET',
        cache: cache || false,
        error: this.handleError
    });
};
