#region UnityEngine.VFXModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VFXModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
    [NativeType(Header = "Modules/VFX/Public/VFXEventAttribute.h")]
    [RequiredByNativeCode]
    public sealed class VFXEventAttribute : IDisposable
    {
        public VFXEventAttribute(VFXEventAttribute original);

        ~VFXEventAttribute();

        public void Dispose();
        [NativeName("HasValueFromScript<bool>")]
        public bool HasBool(int nameID);
        [NativeName("HasValueFromScript<int>")]
        public bool HasInt(int nameID);
        [NativeName("HasValueFromScript<UInt32>")]
        public bool HasUint(int nameID);
        [NativeName("HasValueFromScript<float>")]
        public bool HasFloat(int nameID);
        [NativeName("HasValueFromScript<Vector2f>")]
        public bool HasVector2(int nameID);
        [NativeName("HasValueFromScript<Vector3f>")]
        public bool HasVector3(int nameID);
        [NativeName("HasValueFromScript<Vector4f>")]
        public bool HasVector4(int nameID);
        [NativeName("HasValueFromScript<Matrix4x4f>")]
        public bool HasMatrix4x4(int nameID);
        [NativeName("SetValueFromScript<bool>")]
        public void SetBool(int nameID, bool b);
        [NativeName("SetValueFromScript<int>")]
        public void SetInt(int nameID, int i);
        [NativeName("SetValueFromScript<UInt32>")]
        public void SetUint(int nameID, uint i);
        [NativeName("SetValueFromScript<float>")]
        public void SetFloat(int nameID, float f);
        [NativeName("SetValueFromScript<Vector2f>")]
        public void SetVector2(int nameID, Vector2 v);
        [NativeName("SetValueFromScript<Vector3f>")]
        public void SetVector3(int nameID, Vector3 v);
        [NativeName("SetValueFromScript<Vector4f>")]
        public void SetVector4(int nameID, Vector4 v);
        [NativeName("SetValueFromScript<Matrix4x4f>")]
        public void SetMatrix4x4(int nameID, Matrix4x4 v);
        [NativeName("GetValueFromScript<bool>")]
        public bool GetBool(int nameID);
        [NativeName("GetValueFromScript<int>")]
        public int GetInt(int nameID);
        [NativeName("GetValueFromScript<UInt32>")]
        public uint GetUint(int nameID);
        [NativeName("GetValueFromScript<float>")]
        public float GetFloat(int nameID);
        [NativeName("GetValueFromScript<Vector2f>")]
        public Vector2 GetVector2(int nameID);
        [NativeName("GetValueFromScript<Vector3f>")]
        public Vector3 GetVector3(int nameID);
        [NativeName("GetValueFromScript<Vector4f>")]
        public Vector4 GetVector4(int nameID);
        [NativeName("GetValueFromScript<Matrix4x4f>")]
        public Matrix4x4 GetMatrix4x4(int nameID);
        public bool HasBool(string name);
        public bool HasInt(string name);
        public bool HasUint(string name);
        public bool HasFloat(string name);
        public bool HasVector2(string name);
        public bool HasVector3(string name);
        public bool HasVector4(string name);
        public bool HasMatrix4x4(string name);
        public void SetBool(string name, bool b);
        public void SetInt(string name, int i);
        public void SetUint(string name, uint i);
        public void SetFloat(string name, float f);
        public void SetVector2(string name, Vector2 v);
        public void SetVector3(string name, Vector3 v);
        public void SetVector4(string name, Vector4 v);
        public void SetMatrix4x4(string name, Matrix4x4 v);
        public bool GetBool(string name);
        public int GetInt(string name);
        public uint GetUint(string name);
        public float GetFloat(string name);
        public Vector2 GetVector2(string name);
        public Vector3 GetVector3(string name);
        public Vector4 GetVector4(string name);
        public Matrix4x4 GetMatrix4x4(string name);
        public void CopyValuesFrom([NotNull("ArgumentNullException")] VFXEventAttribute eventAttibute);
    }
}
