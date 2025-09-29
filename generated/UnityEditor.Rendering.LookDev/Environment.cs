#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;
using UnityEngine.Rendering.LookDev;

namespace UnityEditor.Rendering.LookDev
{
    public class Environment : ScriptableObject
    {

        public float rotation;
        public float exposure;
        public Color shadowColor;

        public Environment();

        public Cubemap cubemap { get; set; }
        public float sunLatitude { get; set; }
        public float sunLongitude { get; set; }
        public Sky sky { get; }

        public void ResetToBrightestSpot();
    }
}
