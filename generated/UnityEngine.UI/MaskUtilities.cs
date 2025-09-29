#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UI
{
    public class MaskUtilities
    {

        public MaskUtilities();

        public static void Notify2DMaskStateChanged(Component mask);
        public static void NotifyStencilStateChanged(Component mask);
        public static Transform FindRootSortOverrideCanvas(Transform start);
        public static int GetStencilDepth(Transform transform, Transform stopAfter);
        public static bool IsDescendantOrSelf(Transform father, Transform child);
        public static RectMask2D GetRectMaskForClippable(IClippable clippable);
        public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks);
    }
}
