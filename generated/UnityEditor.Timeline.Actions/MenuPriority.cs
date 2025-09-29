#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

namespace UnityEditor.Timeline.Actions
{
    public static class MenuPriority
    {

        public const int defaultPriority = 9000;
        public const int separatorAt = 1000;
        public static class TimelineActionSection
        {

            public const int start = 1000;
            public const int copy = 1100;
            public const int paste = 1200;
            public const int duplicate = 1300;
            public const int delete = 1400;
            public const int keyAllAnimated = 1450;
            public const int matchContent = 1500;
        }
        public static class TrackActionSection
        {

            public const int start = 2000;
            public const int lockTrack = 2100;
            public const int lockSelected = 2150;
            public const int mute = 2200;
            public const int muteSelected = 2250;
            public const int showHideMarkers = 2300;
            public const int removeInvalidMarkers = 2400;
            public const int editInAnimationWindow = 2800;
        }
        public static class AddTrackMenu
        {

            public const int start = 3000;
            public const int addLayerTrack = 3000;
        }
        public static class ClipEditActionSection
        {

            public const int start = 4000;
            public const int editInAnimationWindow = 4100;
            public const int editSubTimeline = 4200;
        }
        public static class ClipActionSection
        {

            public const int start = 5000;
            public const int trimStart = 5100;
            public const int trimEnd = 5110;
            public const int split = 5120;
            public const int completeLastLoop = 6000;
            public const int trimLastLoop = 6110;
            public const int matchDuration = 6120;
            public const int doubleSpeed = 7000;
            public const int halfSpeed = 7110;
            public const int resetDuration = 8000;
            public const int resetSpeed = 8110;
            public const int resetAll = 8120;
            public const int tile = 5300;
            public const int findSourceAsset = 5400;
        }
        public static class MarkerActionSection
        {

            public const int start = 6000;
        }
        public static class CustomTimelineActionSection
        {

            public const int start = 7000;
        }
        public static class CustomTrackActionSection
        {

            public const int start = 8000;
            public const int convertToClipMode = 8100;
            public const int convertFromClipMode = 8200;
            public const int applyTrackOffset = 8300;
            public const int applySceneOffset = 8310;
            public const int applyAutoOffset = 8320;
            public const int addOverrideTrack = 8500;
            public const int customTrackAction = 8900;
        }
        public static class CustomClipActionSection
        {

            public const int start = 9000;
            public const int matchPrevious = 9100;
            public const int matchNext = 9110;
            public const int resetOffset = 9120;
            public const int customClipAction = 9900;
        }
        public static class AddItem
        {

            public const int addGroup = 10000;
            public const int addTrack = 11000;
            public const int addCustomTrack = 12000;
            public const int addClip = 13000;
            public const int addCustomClip = 14000;
            public const int addMarker = 15000;
            public const int addCustomMarker = 16000;
        }
    }
}
