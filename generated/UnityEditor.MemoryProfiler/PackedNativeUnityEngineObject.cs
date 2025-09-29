#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.MemoryProfiler
{
    public struct PackedNativeUnityEngineObject
    {

        public PackedNativeUnityEngineObject(string name, int instanceId, int size, int nativeTypeArrayIndex, HideFlags hideFlags, ObjectFlags flags, long nativeObjectAddress);

        public bool isPersistent { get; }
        public bool isDontDestroyOnLoad { get; }
        public bool isManager { get; }
        public string name { get; }
        public int instanceId { get; }
        public int size { get; }
        [Obsolete("PackedNativeUnityEngineObject.classId is obsolete. Use PackedNativeUnityEngineObject.nativeTypeArrayIndex instead (UnityUpgradable) -> nativeTypeArrayIndex")]
        public int classId { get; }
        public int nativeTypeArrayIndex { get; }
        public HideFlags hideFlags { get; }
        public long nativeObjectAddress { get; }
        public enum ObjectFlags
        {

            IsDontDestroyOnLoad = 1,
            IsPersistent = 2,
            IsManager = 4
        }
    }
}
