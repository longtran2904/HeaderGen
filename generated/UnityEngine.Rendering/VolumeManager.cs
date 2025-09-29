#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.Rendering
{
    public sealed class VolumeManager
    {

        public static VolumeManager instance { get; }
        public VolumeStack stack { get; set; }
        [Obsolete("Please use baseComponentTypeArray instead.")]
        public IEnumerable<Type> baseComponentTypes { get; }
        public Type[] baseComponentTypeArray { get; }

        public VolumeStack CreateStack();
        public void ResetMainStack();
        public void DestroyStack(VolumeStack stack);
        public void Register(Volume volume, int layer);
        public void Unregister(Volume volume, int layer);
        public bool IsComponentActiveInMask<T>(LayerMask layerMask) where T : VolumeComponent;
        [Conditional("UNITY_EDITOR")]
        public void CheckBaseTypes();
        [Conditional("UNITY_EDITOR")]
        public void CheckStack(VolumeStack stack);
        public void Update(Transform trigger, LayerMask layerMask);
        public void Update(VolumeStack stack, Transform trigger, LayerMask layerMask);
        public Volume[] GetVolumes(LayerMask layerMask);
    }
}
