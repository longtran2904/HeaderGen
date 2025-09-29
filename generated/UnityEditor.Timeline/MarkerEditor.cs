#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using UnityEngine.Timeline;

namespace UnityEditor.Timeline
{
    public class MarkerEditor
    {
        public MarkerEditor();

        public virtual MarkerDrawOptions GetMarkerOptions(IMarker marker);
        public virtual void OnCreate(IMarker marker, IMarker clonedFrom);
        public virtual void DrawOverlay(IMarker marker, MarkerUIStates uiState, MarkerOverlayRegion region);
    }
}
