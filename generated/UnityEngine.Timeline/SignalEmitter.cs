#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    [CustomStyle("SignalEmitter")]
    [ExcludeFromPreset]
    [TimelineHelpURL(typeof(SignalEmitter))]
    public class SignalEmitter : Marker, INotification, INotificationOptionProvider
    {

        public SignalEmitter();

        public bool retroactive { get; set; }
        public bool emitOnce { get; set; }
        public SignalAsset asset { get; set; }
    }
}
