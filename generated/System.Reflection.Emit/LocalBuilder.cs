#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection.Emit
{
    public sealed class LocalBuilder : LocalVariableInfo
    {

        public override bool IsPinned { get; }
        public override Type LocalType { get; }
        public override int LocalIndex { get; }
    }
}
