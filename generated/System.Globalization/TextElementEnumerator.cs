#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;

namespace System.Globalization
{
    public class TextElementEnumerator : IEnumerator
    {
        public object Current { get; }
        public int ElementIndex { get; }

        public bool MoveNext();
        public string GetTextElement();
        public void Reset();
    }
}
