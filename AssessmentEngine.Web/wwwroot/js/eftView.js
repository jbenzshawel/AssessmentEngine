const EFTView = function (viewModel) {
    $(function() {
        $(document).on('keypress', function(e) {
            if (e.which === 13) {
                eft.participantTrigger();
            }
        });
    })
    
    setTimeout(BootstrapUtility.toggleLoadingSpinner, 150);

    const imageList = [
        Constants.eftImages.introScreen,
        Constants.eftImages.instructions,
        Constants.eftImages.endScreen
    ];

    const eft = new Vue({
        el: '#eftView',
        data: function () {
            return {
                step: 0,
                currentImageSrc: imageList[0],
                settings: viewModel.settings
            }
        },
        methods: {
            participantTrigger: function () {
                this.step = this.step + 1;
                this.currentImageSrc = this.getStepImage();
            },
            getStepImage: function() {
                const index = this.step < imageList.length
                    ? this.step
                    : imageList.length - 1;

                return imageList[index];
            }
        },
    });
    
    return {
        eft: eft
    }
}