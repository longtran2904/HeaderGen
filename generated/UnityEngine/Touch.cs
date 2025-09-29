#region UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.InputLegacyModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Input/InputBindings.h")]
    public struct Touch
    {

        public int fingerId { get; set; }
        public Vector2 position { get; set; }
        public Vector2 rawPosition { get; set; }
        public Vector2 deltaPosition { get; set; }
        public float deltaTime { get; set; }
        public int tapCount { get; set; }
        public TouchPhase phase { get; set; }
        public float pressure { get; set; }
        public float maximumPossiblePressure { get; set; }
        public TouchType type { get; set; }
        public float altitudeAngle { get; set; }
        public float azimuthAngle { get; set; }
        public float radius { get; set; }
        public float radiusVariance { get; set; }
    }
}
