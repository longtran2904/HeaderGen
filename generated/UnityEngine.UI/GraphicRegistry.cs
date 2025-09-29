#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UI
{
    public class GraphicRegistry
    {
        protected GraphicRegistry();

        public static GraphicRegistry instance { get; }

        public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic);
        public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic);
        public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic);
        public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic);
        public static void DisableGraphicForCanvas(Canvas c, Graphic graphic);
        public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic);
        public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas);
        public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas);
    }
}
