#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.PackageManager.Requests
{
    public sealed class SearchRequest : Request<PackageInfo[]>
    {
        public string PackageIdOrName { get; }

        protected override PackageInfo[] GetResult();
    }
}
