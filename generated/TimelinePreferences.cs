#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System;
using UnityEditor;
using UnityEditor.Timeline;
using UnityEngine;

[FilePath("TimelinePreferences.asset", FilePathAttribute.Location.PreferencesFolder)]
public class TimelinePreferences : ScriptableSingleton<TimelinePreferences>
{

    [SerializeField]
    public TimeFormat timeFormat;
    [NonSerialized]
    [Obsolete("timeUnitInFrame is deprecated. Use timeFormat instead", False)]
    public bool timeUnitInFrame;
    [SerializeField]
    public bool showAudioWaveform;
    [SerializeField]
    public bool snapToFrame;
    [SerializeField]
    public bool edgeSnap;
    [SerializeField]
    public PlaybackScrollMode playbackScrollMode;

    public TimelinePreferences();

    public bool audioScrubbing { get; set; }
    public bool playbackLockedToFrame { get; set; }

    public void Save();
}
