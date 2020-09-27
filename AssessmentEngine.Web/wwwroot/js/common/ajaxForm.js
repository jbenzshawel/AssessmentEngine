var AssessmentEngine = window.AssessmentEngine || {};

AssessmentEngine.AjaxForm = function(config) {
    this.sel = config.sel;
    this.$form = $(this.sel);
    this.action = this.$form.action;
}

AssessmentEngine.AjaxForm.prototype.isValid = function() {
    this.$form.validate();
    return this.$form.valid();
}

AssessmentEngine.AjaxForm.prototype.serialize = function() {
    const data = {};
    this.$form.serializeArray().forEach(x => (data[x.name] = x.value));
    return data;
}

AssessmentEngine.AjaxForm.prototype.submit = function (data, successCallback) {
    if (this.isValid())
        AssessmentEngine.HttpService.postData(this.$form.attr('action'), data, successCallback)
}