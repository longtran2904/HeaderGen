#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

using System.Collections;

namespace System.Security.Policy
{
    public sealed class Evidence : ICollection, IEnumerable
    {

        public Evidence();
        [Obsolete("This constructor is obsolete. Use the constructor which accepts arrays of EvidenceBase instead.")]
        public Evidence(object[] hostEvidence, object[] assemblyEvidence);
        public Evidence(Evidence evidence);
        public Evidence(EvidenceBase[] hostEvidence, EvidenceBase[] assemblyEvidence);

        [Obsolete("Evidence should not be treated as an ICollection. Use GetHostEnumerator and GetAssemblyEnumerator to iterate over the evidence to collect a count.")]
        public int Count { get; }
        public bool IsReadOnly { get; }
        public bool IsSynchronized { get; }
        public bool Locked { get; set; }
        public object SyncRoot { get; }

        [Obsolete("Evidence.AddAssembly has been deprecated. Use AddAssemblyEvidence instead.")]
        public void AddAssembly(object id);
        public void AddAssemblyEvidence<T>(T evidence) where T : EvidenceBase;
        public void AddHostEvidence<T>(T evidence) where T : EvidenceBase;
        public T GetAssemblyEvidence<T>() where T : EvidenceBase;
        public T GetHostEvidence<T>() where T : EvidenceBase;
        [Obsolete("Evidence.AddHost has been deprecated. Use AddHostEvidence instead.")]
        public void AddHost(object id);
        public void Clear();
        public Evidence Clone();
        [Obsolete("Evidence should not be treated as an ICollection. Use the GetHostEnumerator and GetAssemblyEnumerator methods rather than using CopyTo.")]
        public void CopyTo(Array array, int index);
        public IEnumerator GetAssemblyEnumerator();
        [Obsolete("GetEnumerator is obsolete. Use GetAssemblyEnumerator and GetHostEnumerator instead.")]
        public IEnumerator GetEnumerator();
        public IEnumerator GetHostEnumerator();
        public void Merge(Evidence evidence);
        public void RemoveType(Type t);
    }
}
