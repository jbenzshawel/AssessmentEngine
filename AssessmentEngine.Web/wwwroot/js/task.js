const Task = function (viewModel) {
    const MAX_PHOTO_COUNT = 5;
    const HttpService = AssessmentEngine.HttpService;
    const BlockDateTypes = AssessmentEngine.Constants.blockDateTypes;
    const AssessmentTypes = AssessmentEngine.Constants.assessmentTypes;
    
    let loopInProgress = false;
    $(function () {
        $(document).on('keypress', e => {
            if (loopInProgress) return;

            if (e.which === 13) { // enter
                taskViewModel.participantTrigger();
            }
        });
    })

    setTimeout(AssessmentEngine.Utility.toggleLoadingSpinner, 150);

    const eftImages = viewModel.assessmentTypeId === AssessmentTypes.EFT
        ? AssessmentEngine.EftImageBuilder.build(viewModel.blockType)
        : AssessmentEngine.VetFlexImageBuilder.build(viewModel.blockType);
    
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

    const taskViewModel = new Vue({
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

                        if (countDownIndex === 3) {
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
                
                const startPhotoSeries = function () {
                    if (!base.imgVisible) {
                        base.imgVisible = true;
                    }
                    
                    base.saveBlockDateTime(BlockDateTypes.startTaskDateTime);

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

                    const setPhoto = function () {
                        currentSectionType = photoSectionTypes.photo;
                        base.currentImageSrc = eftImages.photos[photoIndex];
                    }
                    
                    let isLastFixationCross = false;

                    const photoCallback = function () {
                        if (elapsedSeconds === 0) {
                            setFixationCross();
                        } else if (
                            currentSectionType === photoSectionTypes.fixationCross &&
                            sectionSeconds === base.settings.fixationCrossTimeSeconds
                        ) {
                            if (isLastFixationCross) {
                                window.clearInterval(photoSeriesID);
                                base.saveBlockDateTime(BlockDateTypes.endTaskDateTime);
                                base.showDataCollection(hasCogLoad);
                            } else {
                                setPhoto();
                            }
                        } else if (
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
                            isLastFixationCross = true;
                        }
                    };

                    const photoSeriesID = setInterval(photoCallback, 1000);
                };

                if (hasCogLoad) {
                    showSeries();
                } else {
                    startCountDown();
                }
            },
            showDataCollection: function (hasCogLoad) {
                if (hasCogLoad)
                    this.showRecall();
                else
                    this.showEmotion();
            },
            showRecall: function () {
                this.imgVisible = false;
                this.emotionVisible = false;
                this.recallImageSrc = eftImages.recallInstructions;
                this.recallVisible = true;
            },
            showEmotion: function () {
                this.imgVisible = false;
                this.recallVisible = false;
                this.emotionImageSrc = eftImages.emotionalIntensity;
                this.emotionVisible = true;
            },
            submitRecall: function (e) {
                e.preventDefault();
                const base = this;

                const validate = () => {
                    const parsed = parseInt(base.seriesRecall, 10);
                    return base.seriesRecall && !Number.isNaN(parsed);
                };
                
                if (!validate()) {
                    confirmationModal.modalTitle = 'Validation error!';
                    confirmationModal.modalText = 'Please enter a number';
                    $('#confirmationModal').modal('show');
                    return;
                }

                if (base.$refs.submitSeriesBtn) {
                    base.$refs.submitSeriesBtn.disabled = true;
                }

                const data = {
                    blockVersionUid: viewModel.currentBlockVersion.uid,
                    seriesRecall: base.seriesRecall
                }

                HttpService.postData('/Tasks/Task/SeriesRecall', data, res => {
                    if (res.isValid) {
                        if (base.$refs.submitSeriesBtn) {
                            base.$refs.submitSeriesBtn.disabled = false;
                        }
                        base.showEmotion();
                    } else {
                        console.log(res.errors);
                    }
                });
            },
            submitEmotion: function (e) {
                e.preventDefault();
                const base = this;

                const validate = () => {
                    const parsed = parseInt(base.emotionRating, 10);
                    
                    return base.emotionRating && !Number.isNaN(parsed) && parsed > 0 && parsed < 8
                };

                if (!validate()) {
                    confirmationModal.modalTitle = 'Validation error!';
                    confirmationModal.modalText = 'Please enter a number between 1 - 7';
                    $('#confirmationModal').modal('show');
                    return;
                }

                if (base.$refs.submitEmotionBtn) {
                    base.$refs.submitEmotionBtn.disabled = true;
                }

                const data = {
                    blockVersionUid: viewModel.currentBlockVersion.uid,
                    emotionRating: base.emotionRating
                }

                HttpService.postData('/Tasks/Task/EmotionRating', data, res => {
                    if (res.isValid) {
                        base.recallVisible = false;
                        base.emotionVisible = false;
                        base.currentImageSrc = AssessmentEngine.Constants.eftImages.endScreen;
                        base.imgVisible = true;
                        base.blockComplete = true;
                        if (base.$refs.submitEmotionBtn) {
                            base.$refs.submitEmotionBtn.disabled = false;
                        }
                        loopInProgress = false;
                    } else {
                        console.log(res.errors);
                    }
                });
            },
            loadNextVersion: function () {
                window.location.href =
                    `/Tasks/Task/Index/${viewModel.taskVersionUid}?blockVersion=${viewModel.nextBlockVersion.blockTypeId}`;
            },
            saveBlockDateTime: function (dateType) {
                const data = {
                    blockVersionUid: viewModel.currentBlockVersion.uid,
                    blockDateType: dateType
                }
                
                HttpService.postData('/Tasks/Task/BlockDateTime', data, res => {
                    if (res && res.isValid) {
                        console.log('Block date time saved')
                    }
                })
            }
        }
    });

    return {
        taskViewModel: taskViewModel
    }
}