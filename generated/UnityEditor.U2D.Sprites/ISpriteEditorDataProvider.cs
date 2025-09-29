#region Unity.2D.Sprite.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Sprite.Editor.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.U2D.Sprites
{
    public interface ISpriteEditorDataProvider
    {

        SpriteImportMode spriteImportMode { get; }
        float pixelsPerUnit { get; }
        UnityEngine.Object targetObject { get; }

        SpriteRect[] GetSpriteRects();
        void SetSpriteRects(SpriteRect[] spriteRects);
        void Apply();
        void InitSpriteEditorDataProvider();
        T GetDataProvider<T>() where T : class;
        bool HasDataProvider(Type type);
    }
}
