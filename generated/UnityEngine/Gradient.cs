#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
    [RequiredByNativeCode]
    public class Gradient : IEquatable<Gradient>
    {
        [RequiredByNativeCode]
        public Gradient();

        ~Gradient();

        public GradientColorKey[] colorKeys { get; set; }
        public GradientAlphaKey[] alphaKeys { get; set; }
        [NativeProperty(IsThreadSafe = True)]
        public GradientMode mode { get; set; }

        [FreeFunction(Name = "Gradient_Bindings::Evaluate", IsThreadSafe = True, HasExplicitThis = True)]
        public Color Evaluate(float time);
        [FreeFunction(Name = "Gradient_Bindings::SetKeys", IsThreadSafe = True, HasExplicitThis = True)]
        public void SetKeys([Unmarshalled] GradientColorKey[] colorKeys, [Unmarshalled] GradientAlphaKey[] alphaKeys);
        public override bool Equals(object o);
        public bool Equals(Gradient other);
        public override int GetHashCode();
    }
}
