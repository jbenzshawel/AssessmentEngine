const ManageParticipantView = function (viewModel) {
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
                    case 'toggleLockout':
                        const participant = grid.getParticipant(this.modalId);
                        AssessmentEngine.HttpService.post(`/Identity/Participant/ToggleLockout?userId=${this.modalId}`, () => {
                            participant.enabled = !participant.enabled;
                        });
                        break;
                    case 'delete':
                        AssessmentEngine.HttpService.post(`/Identity/Participant/Delete?userId=${this.modalId}`, () => {
                            grid.deleteParticipant(this.modalId);
                        });
                        break;
                }
                $('#confirmationModal').modal('hide');
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
            participants: viewModel.participants
        },
        methods: {
            toggleLockout: function (userId) {
                confirmationModal.action = 'toggleLockout';
                confirmationModal.modalId = userId;
                confirmationModal.modalTitle = 'Confirm';
                confirmationModal.modalText = `Are you sure you want to update this participant?`;
                $('#confirmationModal').modal('show');
            },
            confirmDelete: function (userId) {
                confirmationModal.action = 'delete';
                confirmationModal.modalId = userId;
                confirmationModal.modalTitle = 'Confirm Delete';
                confirmationModal.modalText = 'Are you sure you want to delete this participant?';
                $('#confirmationModal').modal('show');
            },
            getParticipant: function (userId) {
                return this.participants.find(x => x.userId === userId);
            },
            deleteParticipant: function (userId) {
                const index = this.participants.findIndex(x => x.userId === userId);
                if (index !== -1)
                    this.participants.splice(index, 1);
            }
        }
    });

    setTimeout(AssessmentEngine.BootstrapUtility.toggleLoadingSpinner, 150);

    return {
        confirmationModal: confirmationModal,
        grid: grid
    };
}