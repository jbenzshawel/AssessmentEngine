const AjaxForm = function(config) {
    this.sel = config.sel;
    this.$form = $(this.sel);
    this.action = this.$form.action;
}

AjaxForm.prototype.isValid = function() {
    this.$form.validate();
    return this.$form.valid();
}

AjaxForm.prototype.serialize = function() {
    const data = {};
    this.$form.serializeArray().forEach(x => (data[x.name] = x.value));

    return data;
}

AjaxForm.prototype.submit = function (data, successCallback, errorCallback) {
    if (this.isValid)
    {
        $.post(this.$form.attr('action'), data, successCallback)
         .fail(errorCallback);
    }
}