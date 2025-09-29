#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.TerrainTools
{
    [MovedFrom("UnityEditor.Experimental.TerrainAPI")]
    public interface IOnPaint
    {

        Texture brushTexture { get; }
        Vector2 uv { get; }
        float brushStrength { get; }
        float brushSize { get; }
        bool hitValidTerrain { get; }
        RaycastHit raycastHit { get; }

        [Obsolete("IOnPaint.RepaintAllInspectors has been deprecated. Use IOnPaint.Repaint instead")]
        void RepaintAllInspectors();
        void Repaint(RepaintFlags flags = RepaintFlags.UI);
    }
}
