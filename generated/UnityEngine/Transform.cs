#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Configuration/UnityConfigure.h")]
    [NativeHeader("Runtime/Transform/Transform.h")]
    [NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
    [RequiredByNativeCode]
    public class Transform : Component, IEnumerable
    {

        protected Transform();

        public Vector3 position { get; set; }
        public Vector3 localPosition { get; set; }
        public Vector3 eulerAngles { get; set; }
        public Vector3 localEulerAngles { get; set; }
        public Vector3 right { get; set; }
        public Vector3 up { get; set; }
        public Vector3 forward { get; set; }
        public Quaternion rotation { get; set; }
        public Quaternion localRotation { get; set; }
        public Vector3 localScale { get; set; }
        public Transform parent { get; set; }
        public Matrix4x4 worldToLocalMatrix { get; }
        public Matrix4x4 localToWorldMatrix { get; }
        public Transform root { get; }
        public int childCount { get; }
        public Vector3 lossyScale { get; }
        [NativeProperty("HasChangedDeprecated")]
        public bool hasChanged { get; set; }
        public int hierarchyCapacity { get; set; }
        public int hierarchyCount { get; }

        public void SetParent(Transform p);
        [FreeFunction("SetParent", HasExplicitThis = True)]
        public void SetParent(Transform parent, bool worldPositionStays);
        public void SetPositionAndRotation(Vector3 position, Quaternion rotation);
        public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation);
        public void GetPositionAndRotation(out Vector3 position, out Quaternion rotation);
        public void GetLocalPositionAndRotation(out Vector3 localPosition, out Quaternion localRotation);
        public void Translate(Vector3 translation, [DefaultValue("Space.Self")] Space relativeTo);
        public void Translate(Vector3 translation);
        public void Translate(float x, float y, float z, [DefaultValue("Space.Self")] Space relativeTo);
        public void Translate(float x, float y, float z);
        public void Translate(Vector3 translation, Transform relativeTo);
        public void Translate(float x, float y, float z, Transform relativeTo);
        public void Rotate(Vector3 eulers, [DefaultValue("Space.Self")] Space relativeTo);
        public void Rotate(Vector3 eulers);
        public void Rotate(float xAngle, float yAngle, float zAngle, [DefaultValue("Space.Self")] Space relativeTo);
        public void Rotate(float xAngle, float yAngle, float zAngle);
        public void Rotate(Vector3 axis, float angle, [DefaultValue("Space.Self")] Space relativeTo);
        public void Rotate(Vector3 axis, float angle);
        public void RotateAround(Vector3 point, Vector3 axis, float angle);
        public void LookAt(Transform target, [DefaultValue("Vector3.up")] Vector3 worldUp);
        public void LookAt(Transform target);
        public void LookAt(Vector3 worldPosition, [DefaultValue("Vector3.up")] Vector3 worldUp);
        public void LookAt(Vector3 worldPosition);
        public Vector3 TransformDirection(Vector3 direction);
        public Vector3 TransformDirection(float x, float y, float z);
        public Vector3 InverseTransformDirection(Vector3 direction);
        public Vector3 InverseTransformDirection(float x, float y, float z);
        public Vector3 TransformVector(Vector3 vector);
        public Vector3 TransformVector(float x, float y, float z);
        public Vector3 InverseTransformVector(Vector3 vector);
        public Vector3 InverseTransformVector(float x, float y, float z);
        public Vector3 TransformPoint(Vector3 position);
        public Vector3 TransformPoint(float x, float y, float z);
        public Vector3 InverseTransformPoint(Vector3 position);
        public Vector3 InverseTransformPoint(float x, float y, float z);
        [FreeFunction("DetachChildren", HasExplicitThis = True)]
        public void DetachChildren();
        public void SetAsFirstSibling();
        public void SetAsLastSibling();
        public void SetSiblingIndex(int index);
        public int GetSiblingIndex();
        public Transform Find(string n);
        [FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = True)]
        public bool IsChildOf([NotNull("ArgumentNullException")] Transform parent);
        [Obsolete("FindChild has been deprecated. Use Find instead (UnityUpgradable) -> Find([mscorlib] System.String)", False)]
        public Transform FindChild(string n);
        public IEnumerator GetEnumerator();
        [Obsolete("warning use Transform.Rotate instead.")]
        public void RotateAround(Vector3 axis, float angle);
        [Obsolete("warning use Transform.Rotate instead.")]
        public void RotateAroundLocal(Vector3 axis, float angle);
        [FreeFunction("GetChild", HasExplicitThis = True)]
        [NativeThrows]
        public Transform GetChild(int index);
        [NativeMethod("GetChildrenCount")]
        [Obsolete("warning use Transform.childCount instead (UnityUpgradable) -> Transform.childCount", False)]
        public int GetChildCount();
    }
}
