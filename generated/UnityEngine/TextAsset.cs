#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Scripting/TextAsset.h")]
    public class TextAsset : Object
    {
        public TextAsset();
        public TextAsset(string text);

        public byte[] bytes { get; }
        public string text { get; }
        public long dataSize { get; }

        public override string ToString();
        public NativeArray<T> GetData<T>() where T : struct;
    }
}
