#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

namespace UnityEngine.UI
{
    [AddComponentMenu("Layout/Horizontal Layout Group", 150)]
    public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
    {

        protected HorizontalLayoutGroup();

        public override void CalculateLayoutInputHorizontal();
        public override void CalculateLayoutInputVertical();
        public override void SetLayoutHorizontal();
        public override void SetLayoutVertical();
    }
}
