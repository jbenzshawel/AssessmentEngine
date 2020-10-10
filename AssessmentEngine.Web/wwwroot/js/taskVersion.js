const TaskVersionView = function (viewModel) {
    const taskVersionId = parseInt($('#TaskVersionId').val(), 10);
    const assessmentTypeId = () => parseInt($('#AssessmentTypeId').val());
    
    $(function () {
        $('#editTaskVersion').on('submit', submitForm);
        $('#ParticipantUid').select2();
        $('#blockTypeContainer').show();
    });

    const toggleBlockGrid = function () {
        if (assessmentTypeId() === 2 && taskVersionId > 0) {
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
                series: x.series,
                sortOrder: x.sortOrder
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
                AssessmentEngine.HttpService.get('/Tasks/TaskVersion/RandomSeries', res => version.series = res)
            },
            getVersion: function (uid) {
                return this.blockVersions.find(x => x.uid === uid);
            }
        }
    });

    const submitForm = function (e) {
        e.preventDefault();

        const ajaxForm = new AssessmentEngine.AjaxForm({
            sel: e.target,
        })
        
        const data = ajaxForm.serialize();

        const success = res => {
            if (taskVersionId === 0) {
                window.location.href = '/Tasks/TaskVersion/Edit/' + res.data.taskVersionId;
                return;
            }
            
            if (res.isValid) {
                $(window).scrollTop(0);
                AssessmentEngine.BootstrapUtility.alertMsg('#ajaxAlert', 'success', 'Task version saved successfully!')
            } else {
                AssessmentEngine.BootstrapUtility.alertMsg('#ajaxAlert', 'danger', 
                    'Please fix the following errors: ' + res.errors.join(', '))
            }
        };
        
        if (taskVersionId > 0 && assessmentTypeId() === 2) {
            data.blockVersions = BlockGrid.blockVersions.map(x => ({
                Id: x.id,
                Uid: x.uid,
                CognitiveLoad: x.cognitiveLoad,
                Series: x.series,
                BlockTypeId: x.blockTypeId,
                sortOrder: x.sortOrder,
            }));
        } else {
            data.blockVersions = null;
        }
        
        ajaxForm.submit(data, success);
    }

    return {
        blockGrid: BlockGrid,
        submitForm: submitForm,
    }
}