#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEditor.Search
{
    public class Query<T> : Query<T, IEnumerable<T>>
    {

        public bool returnPayloadIfEmpty { get; set; }

        public override IEnumerable<T> Apply(IEnumerable<T> data);
        public bool Test(T element);
    }
}
