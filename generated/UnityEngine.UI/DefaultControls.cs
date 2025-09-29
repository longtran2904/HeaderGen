#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;

namespace UnityEngine.UI
{
    public static class DefaultControls
    {
        public static IFactoryControls factory { get; set; }

        public static GameObject CreatePanel(Resources resources);
        public static GameObject CreateButton(Resources resources);
        public static GameObject CreateText(Resources resources);
        public static GameObject CreateImage(Resources resources);
        public static GameObject CreateRawImage(Resources resources);
        public static GameObject CreateSlider(Resources resources);
        public static GameObject CreateScrollbar(Resources resources);
        public static GameObject CreateToggle(Resources resources);
        public static GameObject CreateInputField(Resources resources);
        public static GameObject CreateDropdown(Resources resources);
        public static GameObject CreateScrollView(Resources resources);

        public interface IFactoryControls
        {
            GameObject CreateGameObject(string name, params Type[] components);
        }
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
