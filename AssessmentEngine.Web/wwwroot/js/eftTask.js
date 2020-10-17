const EFTTask = function (viewModel) {
    const MAX_PHOTO_COUNT = 5;
    const httpService = AssessmentEngine.HttpService;
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
                series: viewModel.currentBlockVersion.series,
                seriesRecall: null,
                currentImageSrc: instructionImages[0],
                recallImageSrc: null,
                settings: viewModel.settings,
                imgVisible: true,
                seriesVisible: false,
                recallVisible: false,
                emotionVisible: false,
                emotionImageSrc: null,
                emotionRating: null,
                blockComplete: false,
            }
        },
        methods: {
            participantTrigger: function () {
                this.step = this.step + 1;
                if (this.step < 2) {
                    this.currentImageSrc = this.getInstructionStepImage();
                } else if (hasCogLoad && this.step < 3) {
                    this.currentImageSrc = eftImages.cogLoadInstructions;
                } else if (this.emotionRating === null) {
                    this.startTask();
                } else if (this.blockComplete) {
                    this.loadNextVersion();
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
                            base.showDataCollection(hasCogLoad);
                        }
                    };
                    
                    const photoSeriesID = setInterval(photoCallback,1000);
                };

                if (hasCogLoad) {
                    showSeries();
                } else {
                    startCountDown();
                }
            },
            showDataCollection: function(hasCogLoad) {
                if (hasCogLoad)
                    this.showRecall();
                else
                    this.showEmotion();
            },
            showRecall: function() {
                this.imgVisible = false;
                this.emotionVisible = false;
                this.recallImageSrc = eftImages.recallInstructions;
                this.recallVisible = true;
                this.$refs.submitSeriesBtn.disabled = false;
            },
            showEmotion: function() {
                this.imgVisible = false;
                this.recallVisible = false;
                this.emotionImageSrc = eftImages.emotionalIntensity;
                this.emotionVisible = true;
                this.$refs.submitEmotionBtn.disabled = false;
            },
            submitRecall: function(e) {
                e.preventDefault();
                const base = this;
                
                if (base.seriesRecall === null || base.seriesRecall === '') {
                    return; // todo: display validation message?
                }

                base.$refs.submitSeriesBtn.disabled = true;

                const data = {
                    blockVersionUid: viewModel.currentBlockVersion.uid,
                    seriesRecall: base.seriesRecall
                }
                
                httpService.postData('/Tasks/EFT/SeriesRecall', data, res => {
                    if (res.isValid) {
                        base.$refs.submitSeriesBtn.disabled = false;
                        base.showEmotion();
                    } else {
                        console.log(res.errors);
                    }
                });
            },
            submitEmotion: function(e) {
                e.preventDefault();
                const base = this;
                
                if (base.emotionRating === null || base.emotionRating === '') {
                    return; // todo: display validation message?
                }
                
                base.$refs.submitEmotionBtn.disabled = true;
                
                const data = {
                    blockVersionUid: viewModel.currentBlockVersion.uid,
                    emotionRating: base.emotionRating
                }
                
                httpService.postData('/Tasks/EFT/EmotionRating', data, res => {
                    if (res.isValid) {
                        base.recallVisible = false;
                        base.emotionVisible = false;
                        base.currentImageSrc = AssessmentEngine.Constants.eftImages.endScreen;
                        base.imgVisible = true;
                        base.blockComplete = true;
                        base.$refs.submitEmotionBtn.disabled = false;
                    } else {
                        console.log(res.errors);
                    }
                });
            },
            loadNextVersion: function() {
                window.location.href =
                    `/Tasks/EFT/Index/${viewModel.taskVersionUid}?blockVersion=${viewModel.nextBlockVersion.blockTypeId}`;
            }
        }
    });

    return {
        eft: eft
    }
}