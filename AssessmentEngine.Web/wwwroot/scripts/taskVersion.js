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
        editRow: function(uid) {
            const version = this.blockVersions.find(x => x.uid === uid);
            if (version)
                version.isEditing = !version.isEditing;
        },
        finishEdit: function() {
            this.blockVersions.forEach(x => x.isEditing = false);
        }
    }
});

const submitForm = function(e) {
    e.preventDefault();
    const data = {};
    $(e.target).serializeArray().forEach(x => (data[x.name] = x.value));
    
    data.blockVersions = BlockGrid.blockVersions.map(x => ({
        Id: x.id,
        Uid: x.uid,
        CognitiveLoad: x.cognitiveLoad,
        Series: x.series,
        BlockTypeId: x.blockTypeId
    }));

    const showErrors = errors => {
        // todo: show errors;
    }

    $.post(e.target.action, data, res => {
        if (res.isValid) {
           window.location.href = '/Tasks/TaskVersion/'; 
        } else {
            showErrors(res.errors)
        }
    })
}

$(function() {
    $('#loading').remove();
    $('#blockGrid').show();
    $('#editTaskVersion').on('submit', submitForm);
});