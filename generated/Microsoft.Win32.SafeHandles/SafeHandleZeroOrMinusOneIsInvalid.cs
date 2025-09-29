#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
    public abstract class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
    {

        protected SafeHandleZeroOrMinusOneIsInvalid(bool ownsHandle);

        public override bool IsInvalid { get; }
    }
}
