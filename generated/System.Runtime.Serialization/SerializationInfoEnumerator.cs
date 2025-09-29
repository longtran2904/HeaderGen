#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;

namespace System.Runtime.Serialization
{
    public sealed class SerializationInfoEnumerator : IEnumerator
    {
        public SerializationEntry Current { get; }
        public string Name { get; }
        public object Value { get; }
        public Type ObjectType { get; }

        public bool MoveNext();
        public void Reset();
    }
}
