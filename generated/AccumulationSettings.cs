#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using UnityEngine;

public class AccumulationSettings
{

    public AccumulationSettings();

    public bool CaptureAccumulation { get; set; }
    public int Samples { get; set; }
    public float ShutterInterval { get; set; }
    public ShutterProfileType ShutterType { get; set; }
    public AnimationCurve ShutterProfileCurve { get; set; }
    public float ShutterFullyOpen { get; set; }
    public float ShutterBeginsClosing { get; set; }
    public enum ShutterProfileType
    {

        Range = 0,
        Curve = 1
    }
}
