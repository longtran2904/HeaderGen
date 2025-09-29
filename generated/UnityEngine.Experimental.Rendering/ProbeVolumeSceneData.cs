#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.Experimental.Rendering
{
    public class ProbeVolumeSceneData : ISerializationCallbackReceiver
    {
        public Dictionary<string, Bounds> sceneBounds;

        public ProbeVolumeSceneData(Object parentAsset, string parentSceneDataPropertyName);

        public void SetParentObject(Object parent, string parentSceneDataPropertyName);
        public void OnAfterDeserialize();
        public void OnBeforeSerialize();
    }
}
