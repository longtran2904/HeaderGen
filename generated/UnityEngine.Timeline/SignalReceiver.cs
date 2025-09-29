#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    [TimelineHelpURL(typeof(SignalReceiver))]
    public class SignalReceiver : MonoBehaviour, INotificationReceiver
    {
        public SignalReceiver();

        public void OnNotify(Playable origin, INotification notification, object context);
        public void AddReaction(SignalAsset asset, UnityEvent reaction);
        public int AddEmptyReaction(UnityEvent reaction);
        public void Remove(SignalAsset asset);
        public IEnumerable<SignalAsset> GetRegisteredSignals();
        public UnityEvent GetReaction(SignalAsset key);
        public int Count();
        public void ChangeSignalAtIndex(int idx, SignalAsset newKey);
        public void RemoveAtIndex(int idx);
        public void ChangeReactionAtIndex(int idx, UnityEvent reaction);
        public UnityEvent GetReactionAtIndex(int idx);
        public SignalAsset GetSignalAssetAtIndex(int idx);
    }
}
