const TaskVersionGroupView = function (viewModel) {
    
    $(function () {
        $('#editTaskVersionGroup').on('submit', submitForm);
    });

    const submitForm = function (e) {
        e.preventDefault();

        const ajaxForm = new AssessmentEngine.AjaxForm({
            sel: e.target,
        })
        
        const data = ajaxForm.serialize();

        const success = res => {
            window.location.href = '/Tasks/CounterBalancedTaskVersion/';
        };
        
        ajaxForm.submit(data, success);
    }

    return {
        submitForm: submitForm,
    }
}