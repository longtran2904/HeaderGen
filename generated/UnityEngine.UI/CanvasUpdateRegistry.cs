#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

namespace UnityEngine.UI
{
    public class CanvasUpdateRegistry
    {

        protected CanvasUpdateRegistry();

        public static CanvasUpdateRegistry instance { get; }

        public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element);
        public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element);
        public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element);
        public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element);
        public static void UnRegisterCanvasElementForRebuild(ICanvasElement element);
        public static void DisableCanvasElementForRebuild(ICanvasElement element);
        public static bool IsRebuildingLayout();
        public static bool IsRebuildingGraphics();
    }
}
