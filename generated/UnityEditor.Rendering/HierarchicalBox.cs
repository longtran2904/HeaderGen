#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering
{
    public class HierarchicalBox
    {
        public HierarchicalBox(Color baseColor, Color[] polychromeHandleColors = null, HierarchicalBox parent = null);

        public bool monoHandle { get; set; }
        public Vector3 center { get; set; }
        public Vector3 size { get; set; }
        public Color baseColor { get; set; }

        public void SetBaseColor(Color color);
        public void DrawHull(bool filled);
        public void DrawHandle();
    }
}
