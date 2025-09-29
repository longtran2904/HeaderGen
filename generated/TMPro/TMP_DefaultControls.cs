#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;

namespace TMPro
{
    public static class TMP_DefaultControls
    {

        public static GameObject CreateScrollbar(Resources resources);
        public static GameObject CreateButton(Resources resources);
        public static GameObject CreateText(Resources resources);
        public static GameObject CreateInputField(Resources resources);
        public static GameObject CreateDropdown(Resources resources);
        public struct Resources
        {

            public Sprite standard;
            public Sprite background;
            public Sprite inputField;
            public Sprite knob;
            public Sprite checkmark;
            public Sprite dropdown;
            public Sprite mask;
        }
    }
}
