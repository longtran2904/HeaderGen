#region UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ParticleSystemModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("ParticleSystemScriptingClasses.h")]
    [NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
    [NativeHeader("Modules/ParticleSystem/ParticleSystemForceField.h")]
    [NativeHeader("Modules/ParticleSystem/ParticleSystemForceFieldManager.h")]
    [NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
    [RequireComponent(typeof(Transform))]
    public class ParticleSystemForceField : Behaviour
    {
        public ParticleSystemForceField();

        [NativeName("ForceShape")]
        public ParticleSystemForceFieldShape shape { get; set; }
        public float startRange { get; set; }
        public float endRange { get; set; }
        public float length { get; set; }
        public float gravityFocus { get; set; }
        public Vector2 rotationRandomness { get; set; }
        public bool multiplyDragByParticleSize { get; set; }
        public bool multiplyDragByParticleVelocity { get; set; }
        public Texture3D vectorField { get; set; }
        public ParticleSystem.MinMaxCurve directionX { get; set; }
        public ParticleSystem.MinMaxCurve directionY { get; set; }
        public ParticleSystem.MinMaxCurve directionZ { get; set; }
        public ParticleSystem.MinMaxCurve gravity { get; set; }
        public ParticleSystem.MinMaxCurve rotationSpeed { get; set; }
        public ParticleSystem.MinMaxCurve rotationAttraction { get; set; }
        public ParticleSystem.MinMaxCurve drag { get; set; }
        public ParticleSystem.MinMaxCurve vectorFieldSpeed { get; set; }
        public ParticleSystem.MinMaxCurve vectorFieldAttraction { get; set; }

        [NativeMethod("GetForceFields")]
        [StaticAccessor("GetParticleSystemForceFieldManager()", StaticAccessorType.Dot)]
        public static ParticleSystemForceField[] FindAll();
    }
}
