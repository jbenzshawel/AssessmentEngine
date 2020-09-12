const TaskVersionsView = function (viewModel) {
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
                        $.post(`/Tasks/TaskVersion/Delete/${this.modalId}`, () => {
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
        el: '#grid',
        data: {
            versions: viewModel
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
            }
        }
    });

    return {
        confirmationModal: confirmationModal,
        grid: grid
    };
}