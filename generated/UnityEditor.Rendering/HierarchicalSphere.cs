#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering
{
    public class HierarchicalSphere
    {

        public HierarchicalSphere(Color baseColor, HierarchicalSphere parent = null);

        public Vector3 center { get; set; }
        public float radius { get; set; }
        public Color baseColor { get; set; }

        public void DrawHull(bool filled);
        public void DrawHandle();
    }
}
