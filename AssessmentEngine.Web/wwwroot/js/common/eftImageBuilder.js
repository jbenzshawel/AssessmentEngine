var AssessmentEngine = AssessmentEngine || {};

AssessmentEngine.EftImageBuilder = {};

AssessmentEngine.EftImageBuilder.build = function (blockType) {
    const allImages = AssessmentEngine.Constants.eftImages;
    const images = {
        intro: allImages.intro,
        three: allImages.three,
        two: allImages.two,
        one: allImages.one,
        endScreen: allImages.endScreen,
        fixationCross: allImages.fixationCross
    };

    const setCogLoadImages = () => {
        images.cogLoadInstructions = allImages.cogLoadInstructions;
        images.recallInstructions = allImages.recallInstructions;
    }

    // TODO: finish hooking up builder and photos 1 - 5 for each block type
    switch (blockType) {
        case AssessmentEngine.Constants.blockTypes.EP1:
            images.instructions = allImages.enhanceNoLoadInstructions;
            images.emotionalIntensity = allImages.posRate;
            break;
        case AssessmentEngine.Constants.blockTypes.EP2:
            images.instructions = allImages.enhanceCogLoadInstructions;
            images.emotionalIntensity = allImages.posRate;
            setCogLoadImages();
            break;
        case AssessmentEngine.Constants.blockTypes.EN1:
            break;
        case AssessmentEngine.Constants.blockTypes.EN2:
            setCogLoadImages();
            break;
        case AssessmentEngine.Constants.blockTypes.SP1:
            break;
        case AssessmentEngine.Constants.blockTypes.SP2:
            setCogLoadImages();
            break;
        case AssessmentEngine.Constants.blockTypes.SN1:
            break;
        case AssessmentEngine.Constants.blockTypes.SN2:
            setCogLoadImages();
            break;
        case AssessmentEngine.Constants.blockTypes.VP1:
            break;
        case AssessmentEngine.Constants.blockTypes.VP2:
            setCogLoadImages();
            break;
        case AssessmentEngine.Constants.blockTypes.VN1:
            break;
        case AssessmentEngine.Constants.blockTypes.VN2:
            setCogLoadImages();
            break;
        default:
            throw new Error(`Block type ${blockType} is not supported`);
    }

    return images;
};