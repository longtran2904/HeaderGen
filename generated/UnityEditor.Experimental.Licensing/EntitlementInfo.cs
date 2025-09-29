#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.Experimental.Licensing
{
    [NativeAsStruct]
    [RequiredByNativeCode]
    public class EntitlementInfo
    {

        public EntitlementInfo();

        public string EntitlementId { get; }
        public EntitlementStatus Status { get; }
        public bool IsPackage { get; }
        public int Count { get; }
        public string CustomData { get; }
        public EntitlementGroupInfo[] EntitlementGroupsData { get; }
    }
}
