#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.UIElements
{
    public interface IValueField<T>
    {

        T value { get; set; }

        void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, T startValue);
        void StartDragging();
        void StopDragging();
    }
}
