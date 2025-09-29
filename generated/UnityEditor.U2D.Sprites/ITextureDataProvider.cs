#region Unity.2D.Sprite.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Sprite.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.U2D.Sprites
{
    public interface ITextureDataProvider
    {
        Texture2D texture { get; }
        Texture2D previewTexture { get; }

        void GetTextureActualWidthAndHeight(out int width, out int height);
        Texture2D GetReadableTexture2D();
    }
}
