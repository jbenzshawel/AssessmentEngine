var AssessmentEngine = window.AssessmentEngine || {};

AssessmentEngine.Utility = AssessmentEngine.Utility || {};

AssessmentEngine.Utility.toggleLoadingSpinner = function() {
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

AssessmentEngine.Utility.alertMsg = function (container, type, text) {
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

AssessmentEngine.Utility.formatDate = function(date) {
    if (!date) return '';
    
    return new Date(date).toLocaleString().replace(',' ,'')
}

AssessmentEngine.Utility.isShortDate = strVal => {
    if (typeof strVal === 'boolean') return false;
    
    const dateRegex = /^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$/;

    const split = strVal.toString().split(' ');
    
    if (split && split[0]) {
        const match = split[0].match(dateRegex)
        return match && match.length > 0;
    }

    return false;
}

AssessmentEngine.Utility.sortArray = function(gridData, sortKey, order) {
    return gridData.slice().sort((a, b) => {
        a = a[sortKey];
        b = b[sortKey];
        
        if (this.isShortDate(a) || this.isShortDate(b)) {
            a = new Date(a);
            b = new Date(b);
        }  
        
        if (typeof a === 'string'){
            a = a.toLowerCase();
        }
        
        if (typeof b === 'string') {
            b = b.toLowerCase();
        }
        
        // TODO: add sort logic for additional data types as needed...
        
        return (a === b ? 0 : a > b ? 1 : -1) * order;
    });
}
