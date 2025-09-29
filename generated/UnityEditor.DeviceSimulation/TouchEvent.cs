#region UnityEditor.DeviceSimulatorModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.DeviceSimulatorModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.DeviceSimulation
{
    public struct TouchEvent
    {

        public int touchId { get; }
        public Vector2 position { get; }
        public TouchPhase phase { get; }
    }
}
