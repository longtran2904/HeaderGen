#region UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AndroidJNIModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeType(CodegenOptions.Custom, "ScriptingJvalue")]
    public struct jvalue
    {
        public bool z;
        public sbyte b;
        public char c;
        public short s;
        public int i;
        public long j;
        public float f;
        public double d;
        public nint l;
    }
}
