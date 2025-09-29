#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

namespace UnityEditor.Rendering
{
    public static class ShadowCascadeGUI
    {
        public static void DrawCascades(ref Cascade[] cascades, bool useMetric, float baseMetric);

        public enum HandleState
        {
            Hidden = 0,
            Disabled = 1,
            Enabled = 2
        }
        public struct Cascade
        {
            public float size;
            public float borderSize;
            public HandleState cascadeHandleState;
            public HandleState borderHandleState;
        }
    }
}
