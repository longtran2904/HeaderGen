#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
    [NativeHeader("Modules/Animation/Constraints/ParentConstraint.h")]
    [NativeHeader("Modules/Animation/Constraints/Constraint.bindings.h")]
    [RequireComponent(typeof(Transform))]
    [UsedByNativeCode]
    public sealed class ParentConstraint : Behaviour, IConstraint, IConstraintInternal
    {

        public float weight { get; set; }
        public bool constraintActive { get; set; }
        public bool locked { get; set; }
        public int sourceCount { get; }
        public Vector3 translationAtRest { get; set; }
        public Vector3 rotationAtRest { get; set; }
        public Vector3[] translationOffsets { get; set; }
        public Vector3[] rotationOffsets { get; set; }
        public Axis translationAxis { get; set; }
        public Axis rotationAxis { get; set; }

        public Vector3 GetTranslationOffset(int index);
        public void SetTranslationOffset(int index, Vector3 value);
        public Vector3 GetRotationOffset(int index);
        public void SetRotationOffset(int index, Vector3 value);
        [FreeFunction(Name = "ConstraintBindings::GetSources", HasExplicitThis = True)]
        public void GetSources([NotNull("ArgumentNullException")] List<ConstraintSource> sources);
        public void SetSources(List<ConstraintSource> sources);
        public int AddSource(ConstraintSource source);
        public void RemoveSource(int index);
        public ConstraintSource GetSource(int index);
        public void SetSource(int index, ConstraintSource source);
    }
}
