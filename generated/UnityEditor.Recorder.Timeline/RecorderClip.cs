#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using System.ComponentModel;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace UnityEditor.Recorder.Timeline
{
    [DisplayName("Recorder Clip")]
    public class RecorderClip : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset
    {
        [SerializeField]
        public RecorderSettings settings;

        public RecorderClip();

        public ClipCaps clipCaps { get; }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner);
        public void OnDestroy();
        public void OnBeforeSerialize();
        public void OnAfterDeserialize();
    }
}
