const ManageParticipantView = function () {
    const confirmationModal = new Vue({
        el: '#confirmationModal',
        data: {
            userId: null,
            action: null,
            modalTitle: '',
            modalText: '',
        },
        methods: {
            confirmAction: function () {
                if (!this.userId) return;

                switch (this.action) {
                    case 'toggleLockout':
                        $.post(`/Identity/Participant/ToggleLockout?userId=${this.userId}`, () => window.location.reload());
                        break;
                    case 'delete':
                        $.post(`/Identity/Participant/Delete?userId=${this.userId}`, () => window.location.reload());
                        break;
                }
            },
            cancelAction: function () {
                this.userId = null;
                this.action = null;
                this.modalTitle = '';
                this.modalText = '';
            }
        }
    });
    
    const grid = new Vue({
        el: '#grid',
        methods: {
            toggleLockout: function (userId) {
                confirmationModal.action = 'toggleLockout';
                confirmationModal.userId = userId;
                confirmationModal.modalTitle = 'Confirm';
                confirmationModal.modalText = `Are you sure you want to update this participant?`;
                $('#confirmationModal').modal('show');
            },
            deleteParticipant: function (userId) {
                confirmationModal.action = 'delete';
                confirmationModal.userId = userId;
                confirmationModal.modalTitle = 'Confirm Delete';
                confirmationModal.modalText = 'Are you sure you want to delete this participant?';
                $('#confirmationModal').modal('show');
            }
        }
    });
    
    return {
        confirmationModal: confirmationModal,
        grid: grid
    };
}