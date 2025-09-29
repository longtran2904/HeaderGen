#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor.Build.Reporting
{
    [NativeType(Header = "Modules/BuildReportingEditor/Public/BuildReport.h")]
    public struct BuildFile
    {

        public uint id { get; }
        public string path { get; }
        public string role { get; }
        [NativeName("totalSize")]
        public ulong size { get; }

        public override string ToString();
    }
}
