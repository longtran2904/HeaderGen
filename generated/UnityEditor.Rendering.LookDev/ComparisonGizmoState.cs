#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering.LookDev
{
    public class ComparisonGizmoState
    {

        public ComparisonGizmoState();

        public Vector2 point1 { get; }
        public Vector2 point2 { get; }
        public Vector2 center { get; }
        public float angle { get; }
        public float length { get; }
        public float blendFactor { get; set; }

        public void Update(Vector2 point1, Vector2 point2);
        public void Update(Vector2 center, float length, float angle);
    }
}
