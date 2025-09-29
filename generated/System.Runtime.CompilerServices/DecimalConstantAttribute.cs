#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = False)]
    public sealed class DecimalConstantAttribute : Attribute
    {

        [CLSCompliant(False)]
        public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low);
        public DecimalConstantAttribute(byte scale, byte sign, int hi, int mid, int low);

        public decimal Value { get; }
    }
}
