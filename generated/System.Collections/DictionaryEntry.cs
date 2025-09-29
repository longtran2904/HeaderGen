#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Collections
{
    public struct DictionaryEntry
    {
        public DictionaryEntry(object key, object value);

        public object Key { get; set; }
        public object Value { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Deconstruct(out object key, out object value);
        public override string ToString();
    }
}
