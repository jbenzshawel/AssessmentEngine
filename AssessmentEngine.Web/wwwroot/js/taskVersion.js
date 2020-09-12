const TaskVersionView = function (viewModel) {
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
                id: x.id,
                uid: x.uid,
                blockTypeId: x.blockTypeId,
                blockType: x.blockType.name,
                cognitiveLoad: x.cognitiveLoad,
                series: x.series
            }))
        },
        methods: {
            editRow: function (uid) {
                this.finishEdit();
                const version = this.getVersion(uid);
                if (version)
                    version.isEditing = !version.isEditing;
            },
            finishEdit: function () {
                this.blockVersions.forEach(x => x.isEditing = false);
            },
            toggleCheck: function (uid, event) {
                const version = this.getVersion(uid);
                if (event.target.checked)
                    this.setVersionSeries(version)
                else
                    version.series = null;
            },
            setVersionSeries: function (version) {
                HttpService.get('/Tasks/TaskVersion/RandomSeries', res => version.series = res)
            },
            getVersion: function (uid) {
                return this.blockVersions.find(x => x.uid === uid);
            }
        }
    });

    const submitForm = function (e) {
        e.preventDefault();

        const ajaxForm = new AjaxForm({
            sel: e.target,
        })
        
        const data = ajaxForm.serialize();

        const success = res => {
            const $ajaxAlert = $('#ajaxAlert');
            
            if ($ajaxAlert.length === 0)
            {
                window.location.href = '/Tasks/TaskVersion/Edit/' + res.data.taskVersionId;
                return;
            }
            
            if (res.isValid) {
                BootstrapUtility.alertMsg('#ajaxAlert', 'success', 'Task version saved successfully!')
            } else {
                BootstrapUtility.alertMsg('#ajaxAlert', 'danger', 
                    'Please fix the following errors: ' + res.errors.join(', '))
            }
        };

        data.blockVersions = BlockGrid.blockVersions.map(x => ({
            Id: x.id,
            Uid: x.uid,
            CognitiveLoad: x.cognitiveLoad,
            Series: x.series,
            BlockTypeId: x.blockTypeId
        }));

        ajaxForm.submit(data, success);
    }

    return {
        blockGrid: BlockGrid,
        submitForm: submitForm,
    }
}