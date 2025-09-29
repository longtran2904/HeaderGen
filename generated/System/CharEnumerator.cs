#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.Collections.Generic;

namespace System
{
    public sealed class CharEnumerator : ICloneable, IDisposable, IEnumerator, IEnumerator<char>
    {

        public char Current { get; }

        public object Clone();
        public bool MoveNext();
        public void Dispose();
        public void Reset();
    }
}
