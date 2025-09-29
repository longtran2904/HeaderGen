#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.Rendering
{
    public interface IVolumeAdditionalGizmo
    {

        Type type { get; }

        void OnBoxColliderDraw(IVolume scr, BoxCollider c);
        void OnSphereColliderDraw(IVolume scr, SphereCollider c);
        void OnMeshColliderDraw(IVolume scr, MeshCollider c);
    }
}
