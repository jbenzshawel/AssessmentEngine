const ManageParticipantView = function () {
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
                        $.post(`/Identity/Participant/ToggleLockout?userId=${this.modalId}`, () => window.location.reload());
                        break;
                    case 'delete':
                        $.post(`/Identity/Participant/Delete?userId=${this.modalId}`, () => window.location.reload());
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
        methods: {
            toggleLockout: function (userId) {
                confirmationModal.action = 'toggleLockout';
                confirmationModal.modalId = userId;
                confirmationModal.modalTitle = 'Confirm';
                confirmationModal.modalText = `Are you sure you want to update this participant?`;
                $('#confirmationModal').modal('show');
            },
            deleteParticipant: function (userId) {
                confirmationModal.action = 'delete';
                confirmationModal.modalId = userId;
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