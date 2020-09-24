const EFTTask = function (viewModel) {
    $(function () {
        $(document).on('keypress', e => {
            if (e.which === 13) { // enter
                eft.participantTrigger();
            }
        });
    })

    setTimeout(BootstrapUtility.toggleLoadingSpinner, 150);

    const instructionImages = [
        Constants.eftImages.introScreen,
        Constants.eftImages.instructions,
        Constants.eftImages.endScreen
    ];

    const countDownImages = [
        Constants.eftImages.three,
        Constants.eftImages.two,
        Constants.eftImages.one,
        
    ];

    const eft = new Vue({
        el: '#eftView',
        data: function () {
            return {
                step: 0,
                currentImageSrc: instructionImages[0],
                settings: viewModel.settings
            }
        },
        methods: {
            participantTrigger: function () {
                this.step = this.step + 1;
                if (this.step < 2) {
                    this.currentImageSrc = this.getInstructionStepImage();
                } else {
                    this.startTask();
                }
            },
            getInstructionStepImage: function () {
                const index = this.step < instructionImages.length
                    ? this.step
                    : instructionImages.length - 1;

                return instructionImages[index];
            },
            startTask: function () {
                // TODO(AB): refactor to use promises or one set interval loop?
                // another option would be to pass a callback to fixation cross 
                const base = this;
                let countDownIndex = 0;
                const countDownCallBack = function () {
                    base.currentImageSrc = countDownImages[countDownIndex];
                    countDownIndex++;
                    
                    if (countDownIndex === 3){
                        window.clearInterval(countDownID);
                        startFixationCross();
                    }
                };
                
                const countDownID = setInterval(countDownCallBack, 1000);
                
                const startFixationCross = function() {
                    let fixationIndex = 0;
                    const fixationCallback = function() {
                        if (fixationIndex === 0) {
                            base.currentImageSrc = Constants.eftImages.fixationCross
                        }
                        
                        fixationIndex++;
                        
                        if (fixationIndex === 4) {
                            window.clearInterval(fixationID)
                            // could call callback here
                        }
                    };
                    
                    const fixationID = setInterval( fixationCallback,1000);
                };
                
            }
        },
    });

    return {
        eft: eft
    }
}