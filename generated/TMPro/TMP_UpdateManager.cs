#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

namespace TMPro
{
    public class TMP_UpdateManager
    {
        public static void RegisterTextElementForLayoutRebuild(TMP_Text element);
        public static void RegisterTextElementForGraphicRebuild(TMP_Text element);
        public static void RegisterTextElementForCullingUpdate(TMP_Text element);
        public static void UnRegisterTextElementForRebuild(TMP_Text element);
    }
}
