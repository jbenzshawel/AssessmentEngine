const TaskVersion = function (viewModel) {
    $(function () {
        $('#editTaskVersion').on('submit', submitForm);
        $('#AssessmentTypeId').on('change', toggleBlockGrid);
        toggleBlockGrid()
    });

    const toggleBlockGrid = function () {
        if (parseInt($('#AssessmentTypeId').val()) === 2) { // 2 = EFT
            $('#blockTypeContainer').show();
        } else {
            $('#blockTypeContainer').hide();
        }
    }
    
    const BlockGrid = new Vue({
        el: '#blockGrid',
        data: {
            blockVersions: viewModel.blockVersions.map(x => ({
                isEditing: false,
                uid: x.uid,
                blockTypeId: x.blockTypeId,
                blockType: x.blockType.name,
                cognitiveLoad: x.cognitiveLoad,
                series: x.series
            }))
        },
        methods: {
            editRow: function (uid) {
                const version = this.blockVersions.find(x => x.uid === uid);
                if (version)
                    version.isEditing = !version.isEditing;
            },
            finishEdit: function () {
                this.blockVersions.forEach(x => x.isEditing = false);
            }
        }
    });

    const submitForm = function (e) {
        e.preventDefault();

        const ajaxForm = new AjaxForm({
            sel: e.target,
        })

        const showErrors = errors => {

        }

        const success = res => {
            if (res.isValid) {
                window.location.href = '/Tasks/TaskVersion/';
            } else {
                showErrors(res.errors)
            }
        };

        const data = ajaxForm.serialize();
        data.blockVersions = BlockGrid.blockVersions.map(x => ({
            Id: x.id,
            Uid: x.uid,
            CognitiveLoad: x.cognitiveLoad,
            Series: x.series,
            BlockTypeId: x.blockTypeId
        }));

        ajaxForm.submit(data, success, showErrors);
    }

    return {
        blockGrid: BlockGrid,
        submitForm: submitForm,
    }
}