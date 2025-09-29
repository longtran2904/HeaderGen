#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.TerrainTools
{
    [MovedFrom("UnityEditor.Experimental.TerrainAPI")]
    public interface IOnSceneGUI
    {

        SceneView sceneView { get; }
        Texture brushTexture { get; }
        float brushStrength { get; }
        float brushSize { get; }
        bool hitValidTerrain { get; }
        RaycastHit raycastHit { get; }
        int controlId { get; }

        void Repaint(RepaintFlags flags = RepaintFlags.UI);
    }
}
