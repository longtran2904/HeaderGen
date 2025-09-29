#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.Timeline
{
    public class TimelineClip : ICurvesOwner, ISerializationCallbackReceiver
    {

        public static readonly ClipCaps kDefaultClipCaps;
        public static readonly float kDefaultClipDurationInSeconds;
        public static readonly double kTimeScaleMin;
        public static readonly double kTimeScaleMax;

        public bool hasPreExtrapolation { get; }
        public bool hasPostExtrapolation { get; }
        public double timeScale { get; set; }
        public double start { get; set; }
        public double duration { get; set; }
        public double end { get; }
        public double clipIn { get; set; }
        public string displayName { get; set; }
        public double clipAssetDuration { get; }
        public AnimationClip curves { get; }
        public bool hasCurves { get; }
        public Object asset { get; set; }
        [Obsolete("underlyingAsset property is obsolete. Use asset property instead", True)]
        public Object underlyingAsset { get; set; }
        [Obsolete("parentTrack is deprecated and will be removed in a future release. Use GetParentTrack() and TimelineClipExtensions::MoveToTrack() or TimelineClipExtensions::TryMoveToTrack() instead.", False)]
        public TrackAsset parentTrack { get; set; }
        public double easeInDuration { get; set; }
        public double easeOutDuration { get; set; }
        [Obsolete("Use easeOutTime instead (UnityUpgradable) -> easeOutTime", True)]
        public double eastOutTime { get; }
        public double easeOutTime { get; }
        public double blendInDuration { get; set; }
        public double blendOutDuration { get; set; }
        public BlendCurveMode blendInCurveMode { get; set; }
        public BlendCurveMode blendOutCurveMode { get; set; }
        public bool hasBlendIn { get; }
        public bool hasBlendOut { get; }
        public AnimationCurve mixInCurve { get; set; }
        public float mixInPercentage { get; }
        public double mixInDuration { get; }
        public AnimationCurve mixOutCurve { get; set; }
        public double mixOutTime { get; }
        public double mixOutDuration { get; }
        public float mixOutPercentage { get; }
        public bool recordable { get; }
        [Obsolete("exposedParameter is deprecated and will be removed in a future release", True)]
        public List<string> exposedParameters { get; }
        public ClipCaps clipCaps { get; }
        public AnimationClip animationClip { get; }
        public ClipExtrapolation postExtrapolationMode { get; }
        public ClipExtrapolation preExtrapolationMode { get; }
        public double extrapolatedStart { get; }
        public double extrapolatedDuration { get; }

        public TrackAsset GetParentTrack();
        public float EvaluateMixOut(double time);
        public float EvaluateMixIn(double time);
        public double ToLocalTime(double time);
        public double ToLocalTimeUnbound(double time);
        public bool IsExtrapolatedTime(double sequenceTime);
        public bool IsPreExtrapolatedTime(double sequenceTime);
        public bool IsPostExtrapolatedTime(double sequenceTime);
        public void CreateCurves(string curvesClipName);
        public override string ToString();
        public void ConformEaseValues();
        public enum ClipExtrapolation
        {

            None = 0,
            Hold = 1,
            Loop = 2,
            PingPong = 3,
            Continue = 4
        }
        public enum BlendCurveMode
        {

            Auto = 0,
            Manual = 1
        }
    }
}
