#region Unity.2D.Sprite.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Sprite.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.U2D.Sprites
{
    public abstract class SpriteEditorModuleBase
    {

        protected SpriteEditorModuleBase();

        public ISpriteEditor spriteEditor { get; }
        public abstract string moduleName { get; }

        public abstract bool CanBeActivated();
        public abstract void DoMainGUI();
        public abstract void DoToolbarGUI(Rect drawArea);
        public abstract void OnModuleActivate();
        public abstract void OnModuleDeactivate();
        public abstract void DoPostGUI();
        public abstract bool ApplyRevert(bool apply);
    }
}
