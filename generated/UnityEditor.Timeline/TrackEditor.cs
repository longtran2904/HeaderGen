#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Timeline;

namespace UnityEditor.Timeline
{
    public class TrackEditor
    {
        public static readonly float DefaultTrackHeight;
        public static readonly float MinimumTrackHeight;
        public static readonly float MaximumTrackHeight;

        public TrackEditor();

        public virtual TrackDrawOptions GetTrackOptions(TrackAsset track, UnityEngine.Object binding);
        public string GetErrorText(TrackAsset track, UnityEngine.Object boundObject, TrackBindingErrors detectErrors);
        public Color GetTrackColor(TrackAsset track);
        public Type GetBindingType(TrackAsset track);
        public virtual void OnCreate(TrackAsset track, TrackAsset copiedFrom);
        public virtual void OnTrackChanged(TrackAsset track);
        public virtual bool IsBindingAssignableFrom(UnityEngine.Object candidate, TrackAsset track);
        public virtual UnityEngine.Object GetBindingFrom(UnityEngine.Object candidate, TrackAsset track);
    }
}
