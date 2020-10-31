var AssessmentEngine = AssessmentEngine || {};

AssessmentEngine.Constants = {
    eftImages: {
        three: '/img/eft/3.jpg',
        two: '/img/eft/2.jpg',
        one: '/img/eft/1.jpg',
        cogLoadInstructions: '/img/eft/CogLoad_Instructions.jpg',
        endScreen: '/img/eft/EndScreen.jpg',
        enhanceCogLoadInstructions: '/img/eft/Enhance_CogLoad_Instructions.jpg',
        enhanceNoLoadInstructions: '/img/eft/Enhance_NoLoad_Instructions.jpg',
        fixationCross: '/img/eft/Fix_Cross.jpg',
        intro: '/img/eft/Intro.jpg',
        negRate: '/img/eft/NEG_Rate.jpg',
        numberRecallInstructions: '/img/eft/Number_Recall_Instructions.jpg',
        posRate: '/img/eft/POS_Rate.jpg',
        suppressCogLoadInstructions: '/img/eft/Suppress_CogLoad_Instructions.jpg',
        suppressNoLoadInstructions: '/img/eft/Suppress_NoLoad_Instructions.jpg',
        viewCogLoadInstructions: '/img/eft/View_CogLoad_Instructions.jpg',
        viewNoLoadInstructions: '/img/eft/View_NoLoad_Instructions.jpg',
        ep1Photos: [
            '/img/eft/IAPS_Pos_1.jpg',
            '/img/eft/IAPS_Pos_2.jpg',
            '/img/eft/IAPS_Pos_3.jpg',
            '/img/eft/IAPS_Pos_4.jpg',
            '/img/eft/IAPS_Pos_5.jpg',
        ],
        en1Photos: [
            '/img/eft/IAPS_Neg_1.jpg',
            '/img/eft/IAPS_Neg_2.jpg',
            '/img/eft/IAPS_Neg_3.jpg',
            '/img/eft/IAPS_Neg_4.jpg',
            '/img/eft/IAPS_Neg_5.jpg',
        ],
        sp1Photos: [
            '/img/eft/IAPS_Pos_6.jpg',
            '/img/eft/IAPS_Pos_7.jpg',
            '/img/eft/IAPS_Pos_8.jpg',
            '/img/eft/IAPS_Pos_9.jpg',
            '/img/eft/IAPS_Pos_10.jpg',
        ],
        sn1Photos: [
            '/img/eft/IAPS_Neg_6.jpg',
            '/img/eft/IAPS_Neg_7.jpg',
            '/img/eft/IAPS_Neg_8.jpg',
            '/img/eft/IAPS_Neg_9.jpg',
            '/img/eft/IAPS_Neg_10.jpg',
        ],
        vp1Photos: [
            '/img/eft/IAPS_Pos_11.jpg',
            '/img/eft/IAPS_Pos_12.jpg',
            '/img/eft/IAPS_Pos_13.jpg',
            '/img/eft/IAPS_Pos_14.jpg',
            '/img/eft/IAPS_Pos_15.jpg',
        ],
        vn1Photos: [
            '/img/eft/IAPS_Neg_11.jpg',
            '/img/eft/IAPS_Neg_12.jpg',
            '/img/eft/IAPS_Neg_13.jpg',
            '/img/eft/IAPS_Neg_14.jpg',
            '/img/eft/IAPS_Neg_15.jpg',
        ],
        ep2Photos: [
            '/img/eft/IAPS_Pos_16.jpg',
            '/img/eft/IAPS_Pos_17.jpg',
            '/img/eft/IAPS_Pos_18.jpg',
            '/img/eft/IAPS_Pos_19.jpg',
            '/img/eft/IAPS_Pos_20.jpg',
        ],
        en2Photos: [
            '/img/eft/IAPS_Neg_16.jpg',
            '/img/eft/IAPS_Neg_17.jpg',
            '/img/eft/IAPS_Neg_18.jpg',
            '/img/eft/IAPS_Neg_19.jpg',
            '/img/eft/IAPS_Neg_20.jpg',
        ],
        sp2Photos: [
            '/img/eft/IAPS_Pos_21.jpg',
            '/img/eft/IAPS_Pos_22.jpg',
            '/img/eft/IAPS_Pos_23.jpg',
            '/img/eft/IAPS_Pos_24.jpg',
            '/img/eft/IAPS_Pos_25.jpg',
        ],
        sn2Photos: [
            '/img/eft/IAPS_Neg_21.jpg',
            '/img/eft/IAPS_Neg_22.jpg',
            '/img/eft/IAPS_Neg_23.jpg',
            '/img/eft/IAPS_Neg_24.jpg',
            '/img/eft/IAPS_Neg_25.jpg',
        ],
        vp2Photos: [
            '/img/eft/IAPS_Pos_26.jpg',
            '/img/eft/IAPS_Pos_27.jpg',
            '/img/eft/IAPS_Pos_28.jpg',
            '/img/eft/IAPS_Pos_29.jpg',
            '/img/eft/IAPS_Pos_30.jpg',
        ],
        vn2Photos: [
            '/img/eft/IAPS_Neg_26.jpg',
            '/img/eft/IAPS_Neg_27.jpg',
            '/img/eft/IAPS_Neg_28.jpg',
            '/img/eft/IAPS_Neg_29.jpg',
            '/img/eft/IAPS_Neg_30.jpg',
        ],
        practicePosPhotos: [
            '/img/eft/IAPS_Pos_Prac1.jpg',
            '/img/eft/IAPS_Pos_Prac2.jpg',
            '/img/eft/IAPS_Pos_Prac3.jpg',
            '/img/eft/IAPS_Pos_Prac4.jpg',
            '/img/eft/IAPS_Pos_Prac5.jpg',
            '/img/eft/IAPS_Pos_Prac6.jpg',
        ],
        practiceNegPhotos: [
            '/img/eft/IAPS_Neg_Prac1.jpg',
            '/img/eft/IAPS_Neg_Prac2.jpg',
            '/img/eft/IAPS_Neg_Prac3.jpg',
            '/img/eft/IAPS_Neg_Prac4.jpg',
            '/img/eft/IAPS_Neg_Prac5.jpg',
            '/img/eft/IAPS_Neg_Prac6.jpg',
        ]
    },
    blockTypes: {
        unknown: 0,
        EP1: 1,
        EP2: 2,
        EN1: 3,
        EN2: 4,
        SP1: 5,
        SP2: 6,
        SN1: 7,
        SN2: 8,
        VP1: 9,
        VP2: 10,
        VN1: 11,
        VN2: 12
    },
    blockDateTypes: {
        unknown: 0,
        startTaskDateTime: 1,
        endTaskDateTime: 2,
        taskCompleteDateTime: 3
    }
}