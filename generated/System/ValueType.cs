#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public abstract class ValueType
    {
        protected ValueType();

        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();
    }
}
