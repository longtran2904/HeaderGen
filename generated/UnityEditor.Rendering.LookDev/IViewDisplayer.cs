#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Rendering.LookDev
{
    public interface IViewDisplayer
    {

        event Action<Layout, SidePanel> OnLayoutChanged;
        event Action OnRenderDocAcquisitionTriggered;
        event Action<IMouseEvent> OnMouseEventInView;
        event Action<GameObject, ViewCompositionIndex, Vector2> OnChangingObjectInView;
        event Action<UnityEngine.Object, ViewCompositionIndex, Vector2> OnChangingEnvironmentInView;
        event Action OnClosed;
        event Action OnUpdateRequested;

        Rect GetRect(ViewCompositionIndex index);
        void SetTexture(ViewCompositionIndex index, Texture texture);
        void Repaint();
    }
}
