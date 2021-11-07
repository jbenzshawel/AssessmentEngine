const TaskVersionsView = function (viewModel) {
    const Utility = AssessmentEngine.Utility;

    $(function() {
        $('[data-toggle="popover"]').popover();
    });
    
    const confirmationModal = new Vue({
        el: '#confirmationModal',
        data: {
            modalId: null,
            action: null,
            modalTitle: '',
            modalText: '',
        },
        methods: {
            confirmAction: function () {
                if (!this.modalId) return;
                
                switch (this.action) {
                    case 'delete':
                        AssessmentEngine.HttpService.post(`/Tasks/TaskVersion/Delete/${this.modalId}`, () => {
                            grid.deleteVersion(this.modalId);
                            $('#confirmationModal').modal('hide');
                        });
                        break;
                }
            },
            cancelAction: function () {
                this.modalId = null;
                this.action = null;
                this.modalTitle = '';
                this.modalText = '';
            }
        }
    });

    const grid = new Vue({
        mixins: [AssessmentEngine.Mixins.grid],
        el: '#grid',
        data: function() {
            const sortMetadata = this.buildSortMetadata(viewModel);
            
            const taskVersions = viewModel.map(x => ({
                id: x.id,
                uid: x.uid,
                participantId: x.participantId,
                versionName: x.versionName,
                assessmentType: x.assessmentType,
                participantUrl: x.participantUrl,
                allowEdit: x.allowEdit,
                createdDate: AssessmentEngine.Utility.formatDate(x.createdDate)
            }));
            
            return {
                sortKey: '',
                sortOrders: sortMetadata.sortOrders,
                columns: sortMetadata.columns,
                pageable: new AssessmentEngine.Pageable(taskVersions, this.pageSize),
            };
        },
        methods: {
            confirmDelete: function (id) {
                confirmationModal.modalId = id;
                confirmationModal.action = 'delete';
                confirmationModal.modalTitle = 'Confirm';
                confirmationModal.modalText = `Are you sure you want to delete this assessment version?`;
                $('#confirmationModal').modal('show');
            },
            deleteVersion: function(id) {
                const index = this.versions.findIndex(x => x.id === id);
                if (index !== -1)
                    this.versions.splice(index, 1);
            },
            copyLink: function(id) {
                const task = this.versions.find(x => x.id === id);
                
                navigator.permissions.query({name: 'clipboard-write'}).then(result => {
                    if (result.state === 'granted' || result.state === 'prompt') {
                        navigator.clipboard.writeText(task.participantUrl).then(function() {
                            // success! 
                        }, function() { console.error('Copy to clipboard failed') });
                    }
                });
            }
        }
    });

    setTimeout(Utility.toggleLoadingSpinner, 150);
    
    return {
        confirmationModal: confirmationModal,
        grid: grid
    };
}