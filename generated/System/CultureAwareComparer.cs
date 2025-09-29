#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Serialization;

namespace System
{
    public sealed class CultureAwareComparer : StringComparer, ISerializable
    {
        public override int Compare(string x, string y);
        public override bool Equals(string x, string y);
        public override int GetHashCode(string obj);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}
