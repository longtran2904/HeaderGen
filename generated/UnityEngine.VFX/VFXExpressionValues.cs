#region UnityEngine.VFXModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VFXModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
    [NativeType(Header = "Modules/VFX/Public/VFXExpressionValues.h")]
    [RequiredByNativeCode]
    public class VFXExpressionValues
    {
        [NativeName("GetValueFromScript<bool>")]
        [NativeThrows]
        public bool GetBool(int nameID);
        [NativeName("GetValueFromScript<int>")]
        [NativeThrows]
        public int GetInt(int nameID);
        [NativeName("GetValueFromScript<UInt32>")]
        [NativeThrows]
        public uint GetUInt(int nameID);
        [NativeName("GetValueFromScript<float>")]
        [NativeThrows]
        public float GetFloat(int nameID);
        [NativeName("GetValueFromScript<Vector2f>")]
        [NativeThrows]
        public Vector2 GetVector2(int nameID);
        [NativeName("GetValueFromScript<Vector3f>")]
        [NativeThrows]
        public Vector3 GetVector3(int nameID);
        [NativeName("GetValueFromScript<Vector4f>")]
        [NativeThrows]
        public Vector4 GetVector4(int nameID);
        [NativeName("GetValueFromScript<Matrix4x4f>")]
        [NativeThrows]
        public Matrix4x4 GetMatrix4x4(int nameID);
        [NativeName("GetValueFromScript<Texture*>")]
        [NativeThrows]
        public Texture GetTexture(int nameID);
        [NativeName("GetValueFromScript<Mesh*>")]
        [NativeThrows]
        public Mesh GetMesh(int nameID);
        public AnimationCurve GetAnimationCurve(int nameID);
        public Gradient GetGradient(int nameID);
        public bool GetBool(string name);
        public int GetInt(string name);
        public uint GetUInt(string name);
        public float GetFloat(string name);
        public Vector2 GetVector2(string name);
        public Vector3 GetVector3(string name);
        public Vector4 GetVector4(string name);
        public Matrix4x4 GetMatrix4x4(string name);
        public Texture GetTexture(string name);
        public AnimationCurve GetAnimationCurve(string name);
        public Gradient GetGradient(string name);
        public Mesh GetMesh(string name);
    }
}
