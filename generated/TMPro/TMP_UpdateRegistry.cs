#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine.UI;

namespace TMPro
{
    public class TMP_UpdateRegistry
    {

        protected TMP_UpdateRegistry();

        public static TMP_UpdateRegistry instance { get; }

        public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element);
        public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element);
        public static void UnRegisterCanvasElementForRebuild(ICanvasElement element);
    }
}
