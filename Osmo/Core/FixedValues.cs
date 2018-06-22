﻿using Osmo.Core.Objects;
using Osmo.Core.Reader;
using System.Collections.Generic;

namespace Osmo.Core
{
    static class FixedValues
    {
        internal static void InitializeReader()
        {
            if (readerInterface == null)
                readerInterface = new SkinElementReader(Properties.Resources.SkinningInterface);
            if (readerStandard == null)
                readerStandard = new SkinElementReader(Properties.Resources.SkinningStandard);
            if (readerCatch == null)
                readerCatch = new SkinElementReader(Properties.Resources.SkinningCatch);
            if (readerMania == null)
                readerMania = new SkinElementReader(Properties.Resources.SkinningMania);
            if (readerTaiko == null)
                readerTaiko = new SkinElementReader(Properties.Resources.SkinningTaiko);
            if (readerSounds == null)
                readerSounds = new SkinSoundReader(Properties.Resources.SkinningSounds);
        }

        internal const int WIZARD_INDEX = 1;
        internal const int EDITOR_INDEX = 2;
        internal const int MIXER_INDEX = 3;
        internal const int CONFIG_INDEX = 5;
        internal const int ABOUT_INDEX = 6;
        internal const int TEMPLATE_EDITOR_INDEX = 7;
        
        internal static SkinElementReader readerInterface;
        internal static SkinElementReader readerStandard;
        internal static SkinElementReader readerCatch;
        internal static SkinElementReader readerMania;
        internal static SkinElementReader readerTaiko;
        internal static SkinSoundReader readerSounds;

        internal static readonly List<CompletionData> templateCompletionData =
            new List<CompletionData>()
            {
                new CompletionData("[NAME]", Helper.FindString("completion_template_name")),
                new CompletionData("[AUTHOR]", Helper.FindString("completion_template_author")),
                new CompletionData("[VERSION]", Helper.FindString("completion_template_version")),
                new CompletionData("[SIZE]", Helper.FindString("completion_template_size")),
                new CompletionData("[DATE]", Helper.FindString("completion_template_date"))
            };


        internal static readonly List<CompletionData> skinIniGeneralCompletionData =
            new List<CompletionData>() {
            new CompletionData("Name", Helper.FindString("completion_skin_name")),
            new CompletionData("Author", Helper.FindString("completion_skin_author")),
            new CompletionData("Version", Helper.FindString("completion_skin_version")),
            new CompletionData("AnimationFramerate", Helper.FindString("completion_skin_animationFramerate")),
            new CompletionData("AllowSliderBallTint", Helper.FindString("completion_skin_allowSliderBallTint")),
            new CompletionData("ComboBurstRandom", Helper.FindString("completion_skin_comboBurstRandom")),
            new CompletionData("CursorCentre", Helper.FindString("completion_skin_cursorCentre")),
            new CompletionData("CursorExpand", Helper.FindString("completion_skin_cursorExpand")),
            new CompletionData("CursorRotate", Helper.FindString("completion_skin_cursorRotate")),
            new CompletionData("CursorTrailRotate", Helper.FindString("completion_skin_cursorTrailRotate")),
            new CompletionData("CustomComboBurstSounds", Helper.FindString("completion_skin_customComboSounds")),
            new CompletionData("HitCircleOverlayAboveNumber", Helper.FindString("completion_skin_hitCircleOverlayAboveNumber")),
            new CompletionData("LayeredHitSounds", Helper.FindString("completion_skin_layeredHitsounds")),
            new CompletionData("SliderBallFlip", Helper.FindString("completion_skin_sliderBallFlip")),
            new CompletionData("SliderBallFrames", Helper.FindString("completion_skin_sliderBallFrames")),
            new CompletionData("SliderStyle", Helper.FindString("completion_skin_sliderStyle")),
            new CompletionData("SpinnerFadePlayfield", Helper.FindString("completion_skin_spinnerFadePlayfield")),
            new CompletionData("SpinnerFrequencyModulate", Helper.FindString("completion_skin_spinnerFrequencyModulate")),
            new CompletionData("SpinnerNoBlink", Helper.FindString("completion_skin_spinnerNoBlink")) };

        internal static readonly List<CompletionData> skinIniColoursCompletionData =
            new List<CompletionData>() {
            new CompletionData("Combo1", Helper.FindString("completion_skin_combo1")),
            new CompletionData("Combo2", Helper.FindString("completion_skin_combo2")),
            new CompletionData("Combo3", Helper.FindString("completion_skin_combo3")),
            new CompletionData("Combo4", Helper.FindString("completion_skin_combo4")),
            new CompletionData("Combo5", Helper.FindString("completion_skin_combo5")),
            new CompletionData("Combo6", Helper.FindString("completion_skin_combo6")),
            new CompletionData("Combo7", Helper.FindString("completion_skin_combo7")),
            new CompletionData("Combo8", Helper.FindString("completion_skin_combo8")),
            new CompletionData("InputOverlayText", Helper.FindString("completion_skin_inputOverlayText")),
            new CompletionData("MenuGlow", Helper.FindString("completion_skin_menuGlow")),
            new CompletionData("SliderBall", Helper.FindString("completion_skin_sliderBall")),
            new CompletionData("SliderBorder", Helper.FindString("completion_skin_sliderBorder")),
            new CompletionData("SliderTrackOverride", Helper.FindString("completion_skin_sliderTrackOverride")),
            new CompletionData("SongSelectActiveText", Helper.FindString("completion_skin_songSelectActiveText")),
            new CompletionData("SongSelectInactiveText", Helper.FindString("completion_skin_songSelectInactiveText")),
            new CompletionData("SpinnerBackground", Helper.FindString("completion_skin_spinnerBackground")),
            new CompletionData("StarBreakAdditive", Helper.FindString("completion_skin_starBreakAdditive")) };

        internal static readonly List<CompletionData> skinIniFontsCompletionData =
            new List<CompletionData>() {
            new CompletionData("HitCirclePrefix", Helper.FindString("completion_skin_hitCirclePrefix")),
            new CompletionData("HitCircleOverlap", Helper.FindString("completion_skin_hitCircleOverlap")),
            new CompletionData("ScorePrefix", Helper.FindString("completion_skin_scorePrefix")),
            new CompletionData("ScoreOverlap", Helper.FindString("completion_skin_scoreOverlap")),
            new CompletionData("ComboPrefix", Helper.FindString("completion_skin_comboPrefix")),
            new CompletionData("ComboOverlap", Helper.FindString("completion_skin_comboOverlap")) };

        internal static readonly List<CompletionData> skinIniCTBCompletionData =
            new List<CompletionData>() {
            new CompletionData("HyperDash", Helper.FindString("completion_skin_hyperDash")),
            new CompletionData("HyperDashFruit", Helper.FindString("completion_skin_hyperDashFruit")),
            new CompletionData("HyperDashAfterImage", Helper.FindString("completion_skin_hyperDashAfterImage")) };

        internal static readonly List<CompletionData> skinIniManiaCompletionData =
            new List<CompletionData>() {
            new CompletionData("Keys", Helper.FindString("completion_skin_keys")),
            new CompletionData("ColumnStart", Helper.FindString("completion_skin_columnStart")),
            new CompletionData("ColumnRight", Helper.FindString("completion_skin_columnRight")),
            new CompletionData("ColumnSpacing", Helper.FindString("completion_skin_columnSpacing")),
            new CompletionData("ColumnWidth", Helper.FindString("completion_skin_columnWidth")),
            new CompletionData("ColumnLineWidth", Helper.FindString("completion_skin_columnLineWidth")),
            new CompletionData("BarlineHeight", Helper.FindString("completion_skin_barlineHeight")),
            new CompletionData("LightingNWidth", Helper.FindString("completion_skin_lightingNWidth")),
            new CompletionData("LightingLWidth", Helper.FindString("completion_skin_lightingLWidth")),
            new CompletionData("WidthForNoteHeightScale", Helper.FindString("completion_skin_widthForNoteHeightScale")),
            new CompletionData("HitPosition", Helper.FindString("completion_skin_hitPosition")),
            new CompletionData("LightPosition", Helper.FindString("completion_skin_lightPosition")),
            new CompletionData("ScorePosition", Helper.FindString("completion_skin_scorePosition")),
            new CompletionData("ComboPosition", Helper.FindString("completion_skin_comboPosition")),
            new CompletionData("JudgementLine", Helper.FindString("completion_skin_judgementLine")),
            new CompletionData("LightFramePerSecond", Helper.FindString("completion_skin_lightFramePerSecond")),
            new CompletionData("SpecialStyle", Helper.FindString("completion_skin_specialStyle")),
            new CompletionData("ComboBurstStyle", Helper.FindString("completion_skin_comboBurstStyle")),
            new CompletionData("SplitStages", Helper.FindString("completion_skin_splitStages")),
            new CompletionData("StageSeparation", Helper.FindString("completion_skin_stageSeparation")),
            new CompletionData("SeparateScore", Helper.FindString("completion_skin_separateScore")),
            new CompletionData("KeysUnderNotes", Helper.FindString("completion_skin_keysUnderNotes")),
            new CompletionData("UpsideDown", Helper.FindString("completion_skin_upsideDown")),
            new CompletionData("KeyFlipWhenUpsideDown", Helper.FindString("completion_skin_keyFlipWhenUpsideDown")),
            new CompletionData("KeyFlipWhenUpsideDown#", Helper.FindString("completion_skin_keyFlipWhenUpsideDownHash")),
            new CompletionData("KeyFlipWhenUpsideDown#D", Helper.FindString("completion_skin_keyFlipWhenUpsideDownHashD")),
            new CompletionData("NoteFlipWhenUpsideDown", Helper.FindString("completion_skin_noteFlipWhenUpsideDown")),
            new CompletionData("NoteFlipWhenUpsideDown#", Helper.FindString("completion_skin_noteFlipWhenUpsideDownHash")),
            new CompletionData("NoteFlipWhenUpsideDown#H", Helper.FindString("completion_skin_noteFlipWhenUpsideDownHashH")),
            new CompletionData("NoteFlipWhenUpsideDown#L", Helper.FindString("completion_skin_noteFlipWhenUpsideDownHashL")),
            new CompletionData("NoteFlipWhenUpsideDown#T", Helper.FindString("completion_skin_noteFlipWhenUpsideDownHashT")),
            new CompletionData("NoteBodyStyle", Helper.FindString("completion_skin_noteBodyStyle")),
            new CompletionData("NoteBodyStyle#", Helper.FindString("completion_skin_noteBodyStyleHash")),
            new CompletionData("Colour#", Helper.FindString("completion_skin_colourHash")),
            new CompletionData("ColourLight#", Helper.FindString("completion_skin_colourLightHash")),
            new CompletionData("ColourColumnLine", Helper.FindString("completion_skin_colourColumnLine")),
            new CompletionData("ColourBarline", Helper.FindString("completion_skin_colourBarline")),
            new CompletionData("ColourJudgementLine", Helper.FindString("completion_skin_colourJudgementLine")),
            new CompletionData("ColourKeyWarning", Helper.FindString("completion_skin_colourKeyWarning")),
            new CompletionData("ColourHold", Helper.FindString("completion_skin_colourHold")),
            new CompletionData("ColourBreak", Helper.FindString("completion_skin_colourBreak")),
            new CompletionData("KeyImage#", Helper.FindString("completion_skin_keyImageHash")),
            new CompletionData("KeyImage#D", Helper.FindString("completion_skin_keyImageHashD")),
            new CompletionData("NoteImage#", Helper.FindString("completion_skin_noteImageHash")),
            new CompletionData("NoteImage#H", Helper.FindString("completion_skin_noteImageHashH")),
            new CompletionData("NoteImage#L", Helper.FindString("completion_skin_noteImageHashL")),
            new CompletionData("NoteImage#T", Helper.FindString("completion_skin_noteImageHashT")),
            new CompletionData("StageLeft", Helper.FindString("completion_skin_stageLeft")),
            new CompletionData("StageRight", Helper.FindString("completion_skin_stageRight")),
            new CompletionData("StageBottom", Helper.FindString("completion_skin_stageBottom")),
            new CompletionData("StageHint", Helper.FindString("completion_skin_stageHint")),
            new CompletionData("StageLight", Helper.FindString("completion_skin_stageLight")),
            new CompletionData("LightingN", Helper.FindString("completion_skin_lightingN")),
            new CompletionData("LightingL", Helper.FindString("completion_skin_lightingL")),
            new CompletionData("WarningArrow", Helper.FindString("completion_skin_warningArrow")),
            new CompletionData("Hit0", Helper.FindString("completion_skin_hit0")),
            new CompletionData("Hit50", Helper.FindString("completion_skin_hit50")),
            new CompletionData("Hit100", Helper.FindString("completion_skin_hit100")),
            new CompletionData("Hit200", Helper.FindString("completion_skin_hit200")),
            new CompletionData("Hit300", Helper.FindString("completion_skin_hit300")),
            new CompletionData("Hit300g", Helper.FindString("completion_skin_hit300g")) };

        public const string URI_BASE_LOCALIZATION = "pack://application:,,,/Osmo;component/Localisation/";
    }
}
