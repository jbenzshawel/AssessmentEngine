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
    
    setTimeout(AssessmentEngine.BootstrapUtility.toggleLoadingSpinner, 150);

    const eftImages = AssessmentEngine.EftImageBuilder.build(viewModel.blockType);
    const hasCogLoad = eftImages.cogLoadInstructions !== undefined;
    
    const instructionImages = [
        eftImages.intro,
        eftImages.instructions,
        eftImages.endScreen
    ];

    const countDownImages = [
        eftImages.three,
        eftImages.two,
        eftImages.one,
    ];

    const eft = new Vue({
        el: '#eftView',
        data: function () {
            return {
                step: 0,
                series: 'test', // todo: get from viewModel
                seriesRecall: null,
                currentImageSrc: instructionImages[0],
                recallImageSrc: null,
                settings: viewModel.settings,
                imgVisible: true,
                seriesVisible: false,
                recallVisible: false,
            }
        },
        methods: {
            participantTrigger: function () {
                this.step = this.step + 1;
                if (this.step < 2) {
                    this.currentImageSrc = this.getInstructionStepImage();
                } else if (hasCogLoad && this.step < 3) {
                    this.currentImageSrc = eftImages.cogLoadInstructions;
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
                
                const startCountDown = function () {
                    let countDownIndex = 0;
                    const countDownCallBack = function () {
                        base.currentImageSrc = countDownImages[countDownIndex];
                        if (!base.imgVisible) {
                            base.imgVisible = true;
                        }
                        countDownIndex++;

                        if (countDownIndex === 3){
                            window.clearInterval(countDownID);
                            startPhotoSeries();
                        }
                    };

                    const countDownID = setInterval(countDownCallBack, 1000);
                }
                
                const showSeries = function () {
                    let elapsedSeconds = 0;
                    base.imgVisible = false;
                    base.seriesVisible = true;
                    
                    const seriesCallback = function () {
                        if (elapsedSeconds === base.settings.cognitiveLoadViewTimeSeconds) {
                            window.clearInterval(seriesID);
                            base.seriesVisible = false;
                            startCountDown();
                        }
                        
                        elapsedSeconds++;
                    }
                    
                    const seriesID = setInterval(seriesCallback, 1000);
                }
                
                const startPhotoSeries = function() {
                    if (!base.imgVisible) {
                        base.imgVisible = true;
                    }
                    
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
                        base.currentImageSrc = AssessmentEngine.Constants.eftImages.fixationCross;
                    }
                    
                    const setPhoto = function() {
                        currentSectionType = photoSectionTypes.photo;
                        base.currentImageSrc = eftImages.photos[photoIndex];
                    }

                    const photoCallback = function() {
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
                            loopInProgress = false;
                            if (hasCogLoad) {
                                base.imgVisible = false;
                                base.recallImageSrc = eftImages.recallInstructions;
                                base.recallVisible = true;
                            } else {
                                base.currentImageSrc = AssessmentEngine.Constants.eftImages.endScreen;
                            }
                        }
                    };
                    
                    const photoSeriesID = setInterval(photoCallback,1000);
                };

                if (hasCogLoad) {
                    showSeries();
                } else {
                    startCountDown();
                }
                
                // todo: hook up emotional intensity
            },
            submitRecall: function(e) {
                e.preventDefault();
                // todo: add seven character validation
                console.log(this.seriesRecall); // todo: hook up save 
                this.currentImageSrc = AssessmentEngine.Constants.eftImages.endScreen;
                this.recallVisible = false;
                this.imgVisible = true;
            },
        }
    });

    return {
        eft: eft
    }
}