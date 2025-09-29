#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
    [NativeHeader("Modules/Animation/Constraints/ScaleConstraint.h")]
    [NativeHeader("Modules/Animation/Constraints/Constraint.bindings.h")]
    [RequireComponent(typeof(Transform))]
    [UsedByNativeCode]
    public sealed class ScaleConstraint : Behaviour, IConstraint, IConstraintInternal
    {
        public float weight { get; set; }
        public Vector3 scaleAtRest { get; set; }
        public Vector3 scaleOffset { get; set; }
        public Axis scalingAxis { get; set; }
        public bool constraintActive { get; set; }
        public bool locked { get; set; }
        public int sourceCount { get; }

        [FreeFunction(Name = "ConstraintBindings::GetSources", HasExplicitThis = True)]
        public void GetSources([NotNull("ArgumentNullException")] List<ConstraintSource> sources);
        public void SetSources(List<ConstraintSource> sources);
        public int AddSource(ConstraintSource source);
        public void RemoveSource(int index);
        public ConstraintSource GetSource(int index);
        public void SetSource(int index, ConstraintSource source);
    }
}
