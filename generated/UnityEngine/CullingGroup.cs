#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
    public class CullingGroup : IDisposable
    {

        public CullingGroup();

        ~CullingGroup();

        public StateChanged onStateChanged { get; set; }
        public bool enabled { get; set; }
        public Camera targetCamera { get; set; }

        public void Dispose();
        public void SetBoundingSpheres([Unmarshalled] BoundingSphere[] array);
        public void SetBoundingSphereCount(int count);
        public void EraseSwapBack(int index);
        public static void EraseSwapBack<T>(int index, T[] myArray, ref int size);
        public int QueryIndices(bool visible, int[] result, int firstIndex);
        public int QueryIndices(int distanceIndex, int[] result, int firstIndex);
        public int QueryIndices(bool visible, int distanceIndex, int[] result, int firstIndex);
        [FreeFunction("CullingGroup_Bindings::IsVisible", HasExplicitThis = True)]
        [NativeThrows]
        public bool IsVisible(int index);
        [FreeFunction("CullingGroup_Bindings::GetDistance", HasExplicitThis = True)]
        [NativeThrows]
        public int GetDistance(int index);
        [FreeFunction("CullingGroup_Bindings::SetBoundingDistances", HasExplicitThis = True)]
        public void SetBoundingDistances([Unmarshalled] float[] distances);
        public void SetDistanceReferencePoint(Vector3 point);
        public void SetDistanceReferencePoint(Transform transform);
        public delegate void StateChanged(CullingGroupEvent sphere);
    }
}
