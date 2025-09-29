#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System;
using UnityEditor;
using UnityEngine;

[FilePath("ProjectSettings/TimelineSettings.asset", FilePathAttribute.Location.ProjectFolder)]
public class TimelineProjectSettings : ScriptableSingleton<TimelineProjectSettings>
{
    [HideInInspector]
    [Obsolete("assetDefaultFramerate has been deprecated. Use defaultFrameRate instead.")]
    public float assetDefaultFramerate;

    public TimelineProjectSettings();

    public double defaultFrameRate { get; set; }

    public void Save();
}
