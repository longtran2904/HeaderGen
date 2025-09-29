#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public class ObjectParameter<T> : VolumeParameter<T>
    {

        public ObjectParameter(T value);

        public sealed override bool overrideState { get; set; }
        public sealed override T value { get; set; }
    }
}
