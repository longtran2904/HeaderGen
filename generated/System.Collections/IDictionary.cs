#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Collections
{
    [DefaultMember("Item")]
    public interface IDictionary : ICollection, IEnumerable
    {

        object this[object key] { get; set; }
        ICollection Keys { get; }
        ICollection Values { get; }
        bool IsReadOnly { get; }
        bool IsFixedSize { get; }

        bool Contains(object key);
        void Add(object key, object value);
        void Clear();
        IDictionaryEnumerator GetEnumerator();
        void Remove(object key);
    }
}
