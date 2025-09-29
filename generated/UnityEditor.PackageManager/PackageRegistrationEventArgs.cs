#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.ObjectModel;

namespace UnityEditor.PackageManager
{
    public class PackageRegistrationEventArgs
    {

        public ReadOnlyCollection<PackageInfo> added { get; }
        public ReadOnlyCollection<PackageInfo> removed { get; }
        public ReadOnlyCollection<PackageInfo> changedFrom { get; }
        public ReadOnlyCollection<PackageInfo> changedTo { get; }
    }
}
