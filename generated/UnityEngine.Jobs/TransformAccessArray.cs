#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;
using UnityEngine.Bindings;

namespace UnityEngine.Jobs
{
    [DefaultMember("Item")]
    [NativeType(Header = "Runtime/Transform/ScriptBindings/TransformAccess.bindings.h", CodegenOptions = CodegenOptions.Custom)]
    public struct TransformAccessArray : IDisposable
    {
        public TransformAccessArray(Transform[] transforms, int desiredJobCount = -1);
        public TransformAccessArray(int capacity, int desiredJobCount = -1);

        public Transform this[int index] { get; set; }
        public bool isCreated { get; }
        public int capacity { get; set; }
        public int length { get; }

        public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array);
        public void Dispose();
        public void Add(Transform transform);
        public void RemoveAtSwapBack(int index);
        public void SetTransforms(Transform[] transforms);
    }
}
