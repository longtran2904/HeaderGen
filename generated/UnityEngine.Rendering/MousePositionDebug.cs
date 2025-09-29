#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public class MousePositionDebug
    {
        public MousePositionDebug();

        public static MousePositionDebug instance { get; }

        public void Build();
        public void Cleanup();
        public Vector2 GetMousePosition(float ScreenHeight, bool sceneView);
        public Vector2 GetMouseClickPosition(float ScreenHeight);
    }
}
