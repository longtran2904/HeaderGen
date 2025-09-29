#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering.LookDev
{
    public class StageRuntimeInterface
    {

        public object SRPData;

        public StageRuntimeInterface(Func<bool, GameObject> AddGameObject, Func<Camera> GetCamera, Func<Light> GetSunLight);

        public Camera camera { get; }
        public Light sunLight { get; }

        public GameObject AddGameObject(bool persistent = False);
    }
}
