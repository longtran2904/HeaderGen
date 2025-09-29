#region System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Text.RegularExpressions.dll
#endregion

using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace System.Text.RegularExpressions
{
    [DefaultMember("Item")]
    public class GroupCollection : ICollection, ICollection<Group>, IEnumerable, IEnumerable<Group>, IEnumerable<KeyValuePair<string, Group>>, IList, IList<Group>, IReadOnlyCollection<Group>, IReadOnlyCollection<KeyValuePair<string, Group>>, IReadOnlyDictionary<string, Group>, IReadOnlyList<Group>
    {

        public Group this[int groupnum] { get; }
        public Group this[string groupname] { get; }
        public bool IsReadOnly { get; }
        public int Count { get; }
        public bool IsSynchronized { get; }
        public object SyncRoot { get; }
        public IEnumerable<string> Keys { get; }
        public IEnumerable<Group> Values { get; }

        public IEnumerator GetEnumerator();
        public void CopyTo(Array array, int arrayIndex);
        public void CopyTo(Group[] array, int arrayIndex);
        public bool TryGetValue(string key, out Group value);
        public bool ContainsKey(string key);
    }
}
