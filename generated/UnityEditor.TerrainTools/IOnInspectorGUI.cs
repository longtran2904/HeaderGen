#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.TerrainTools
{
    [MovedFrom("UnityEditor.Experimental.TerrainAPI")]
    public interface IOnInspectorGUI
    {
        void ShowBrushesGUI(int spacing = 5, BrushGUIEditFlags flags = BrushGUIEditFlags.All, int textureResolutionPerTile = 0);
        void Repaint(RepaintFlags flags = RepaintFlags.UI);
    }
}
