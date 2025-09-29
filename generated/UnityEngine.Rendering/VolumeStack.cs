#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public sealed class VolumeStack : IDisposable
    {

        public T GetComponent<T>() where T : VolumeComponent;
        public VolumeComponent GetComponent(Type type);
        public void Dispose();
    }
}
