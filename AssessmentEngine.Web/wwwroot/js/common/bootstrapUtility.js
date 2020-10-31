var AssessmentEngine = window.AssessmentEngine || {};

AssessmentEngine.BootstrapUtility = {};

AssessmentEngine.BootstrapUtility.toggleLoadingSpinner = function() {
    const $viewLoading = $('#viewLoading');
    const $viewContainer = $('#viewContainer');
    if ($viewLoading.is(":visible")) {
        $viewLoading.hide();
        $viewContainer.show();
    } else {
        $viewContainer.hide();
        $viewLoading.show();
    }
}

AssessmentEngine.BootstrapUtility.alertMsg = function (container, type, text) {
    const $container = $(container);
    if ($container.lengh === 0 || !type || !text) return;
    
    const alertTemplate = 
        `<div class="alert alert-__type__ alert-dismissible fade show" role="alert">
            __text__
            <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                <span aria-hidden="true">&times;</span>
            </button>
        </div>`

    const alertHtml = alertTemplate
        .replace('__type__', type)
        .replace('__text__', text);
    
    $container.html(alertHtml);
};

AssessmentEngine.BootstrapUtility.formatDate = function(date) {
    if (!date) return '';
    
    return new Date(date).toLocaleString().replace(',' ,'')
}
