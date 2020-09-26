const EFTTask = function (viewModel) {
    const MAX_PHOTO_COUNT = 5;
    let loopInProgress = false;
    $(function () {
        $(document).on('keypress', e => {
            if (loopInProgress) return;
            
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
                const base = this;
                loopInProgress = true;
                let countDownIndex = 0;
                const countDownCallBack = function () {
                    base.currentImageSrc = countDownImages[countDownIndex];
                    countDownIndex++;
                    
                    if (countDownIndex === 3){
                        window.clearInterval(countDownID);
                        startPhotoSeries();
                    }
                };
                
                const countDownID = setInterval(countDownCallBack, 1000);
                
                const startPhotoSeries = function() {
                    let elapsedSeconds = 0;
                    let sectionSeconds = 0;
                    let photoIndex = 0;
                    let currentSectionType;

                    const sectionTime = base.settings.fixationCrossTimeSeconds 
                                        + base.settings.imageViewTimeSeconds;

                    const photoSectionTypes = {
                        fixationCross: 1,
                        photo: 2
                    };

                    const setFixationCross = function () {
                        currentSectionType = photoSectionTypes.fixationCross
                        base.currentImageSrc = Constants.eftImages.fixationCross;
                    }
                    
                    const setPhoto = function() {
                        currentSectionType = photoSectionTypes.photo;
                        // todo: update with images once get them
                        base.currentImageSrc = 'https://placedog.net/600/400?random&=' + new Date().getTime();
                    }

                    const fixationCallback = function() {
                        if (elapsedSeconds === 0) {
                            setFixationCross();
                        }
                        
                        if (
                            currentSectionType === photoSectionTypes.fixationCross &&
                            sectionSeconds === base.settings.fixationCrossTimeSeconds
                        ) {
                            setPhoto();
                        }

                        if (
                            currentSectionType === photoSectionTypes.photo &&
                            sectionSeconds === sectionTime
                        ) {
                            setFixationCross();
                            photoIndex++;
                            sectionSeconds = 0;
                        }
                        
                        sectionSeconds++;
                        elapsedSeconds++;
                        
                        if (photoIndex === MAX_PHOTO_COUNT) {
                            window.clearInterval(photoSeriesID);
                            base.currentImageSrc = Constants.eftImages.endScreen;
                            loopInProgress = false;
                        }
                    };
                    
                    const photoSeriesID = setInterval(fixationCallback,1000);
                };
                
            }
        },
    });

    return {
        eft: eft
    }
}