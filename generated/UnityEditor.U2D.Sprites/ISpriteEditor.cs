#region Unity.2D.Sprite.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Sprite.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.U2D.Sprites
{
    public interface ISpriteEditor
    {
        List<SpriteRect> spriteRects { set; }
        SpriteRect selectedSpriteRect { get; set; }
        bool enableMouseMoveEvent { set; }
        bool editingDisabled { get; }
        Rect windowDimension { get; }
        float zoomLevel { get; set; }
        Vector2 scrollPosition { get; set; }
        bool showAlpha { get; set; }
        float mipLevel { get; set; }

        T GetDataProvider<T>() where T : class;
        bool HandleSpriteSelection();
        void RequestRepaint();
        void SetDataModified();
        void ApplyOrRevertModification(bool apply);
        VisualElement GetMainVisualContainer();
        void SetPreviewTexture(Texture2D texture, int width, int height);
        void ResetZoomAndScroll();
    }
}
