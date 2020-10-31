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
        images.recallInstructions = allImages.numberRecallInstructions;
    }

    // TODO: finish hooking up builder and photos 1 - 5 for each block type
    switch (blockType) {
        case AssessmentEngine.Constants.blockTypes.EP1:
            images.instructions = allImages.enhanceNoLoadInstructions;
            images.emotionalIntensity = allImages.posRate;
            images.photos = allImages.ep1Photos;
            break;
        case AssessmentEngine.Constants.blockTypes.EP2:
            images.instructions = allImages.enhanceCogLoadInstructions;
            images.emotionalIntensity = allImages.posRate;
            images.photos = allImages.ep2Photos;
            setCogLoadImages();
            break;
        case AssessmentEngine.Constants.blockTypes.EN1:
            images.instructions = allImages.enhanceNoLoadInstructions;
            images.emotionalIntensity = allImages.negRate;
            images.photos = allImages.en1Photos;
            break;
        case AssessmentEngine.Constants.blockTypes.EN2:
            images.instructions = allImages.enhanceCogLoadInstructions;
            images.emotionalIntensity = allImages.negRate;
            images.photos = allImages.en2Photos;
            setCogLoadImages();
            break;
        case AssessmentEngine.Constants.blockTypes.SP1:
            images.instructions = allImages.suppressNoLoadInstructions;
            images.emotionalIntensity = allImages.posRate;
            images.photos = allImages.sp1Photos;
            break;
        case AssessmentEngine.Constants.blockTypes.SP2:
            images.instructions = allImages.suppressCogLoadInstructions;
            images.emotionalIntensity = allImages.posRate;
            images.photos = allImages.sp2Photos;
            setCogLoadImages();
            break;
        case AssessmentEngine.Constants.blockTypes.SN1:
            images.instructions = allImages.suppressNoLoadInstructions;
            images.emotionalIntensity = allImages.negRate;
            images.photos = allImages.sn1Photos;
            break;
        case AssessmentEngine.Constants.blockTypes.SN2:
            images.instructions = allImages.suppressCogLoadInstructions;
            images.emotionalIntensity = allImages.negRate;
            images.photos = allImages.sn2Photos;
            setCogLoadImages();
            break;
        case AssessmentEngine.Constants.blockTypes.VP1:
            images.instructions = allImages.viewNoLoadInstructions;
            images.emotionalIntensity = allImages.posRate;
            images.photos = allImages.vp1Photos;
            break;
        case AssessmentEngine.Constants.blockTypes.VP2:
            images.instructions = allImages.viewCogLoadInstructions;
            images.emotionalIntensity = allImages.posRate;
            images.photos = allImages.vp2Photos;
            setCogLoadImages();
            break;
        case AssessmentEngine.Constants.blockTypes.VN1:
            images.instructions = allImages.viewNoLoadInstructions;
            images.emotionalIntensity = allImages.negRate;
            images.photos = allImages.vn1Photos;
            break;
        case AssessmentEngine.Constants.blockTypes.VN2:
            images.instructions = allImages.viewCogLoadInstructions;
            images.emotionalIntensity = allImages.negRate;
            images.photos = allImages.vn2Photos;
            setCogLoadImages();
            break;
        default:
            throw new Error(`Block type ${blockType} is not supported`);
    }

    return images;
};