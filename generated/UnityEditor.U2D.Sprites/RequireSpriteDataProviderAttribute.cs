#region Unity.2D.Sprite.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Sprite.Editor.dll
#endregion

using System;

namespace UnityEditor.U2D.Sprites
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = False, Inherited = False)]
    public class RequireSpriteDataProviderAttribute : Attribute
    {
        public RequireSpriteDataProviderAttribute(params Type[] types);
    }
}
