#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditor.Build.Reporting
{
    [NativeType(Header = "Modules/BuildReportingEditor/Managed/BuildSummary.bindings.h", CodegenOptions = CodegenOptions.Custom)]
    public struct BuildSummary
    {
        public DateTime buildStartedAt { get; }
        [NativeName("buildGUID")]
        public GUID guid { get; }
        public BuildTarget platform { get; }
        public BuildTargetGroup platformGroup { get; }
        public BuildOptions options { get; }
        public string outputPath { get; }
        public ulong totalSize { get; }
        public TimeSpan totalTime { get; }
        public DateTime buildEndedAt { get; }
        public int totalErrors { get; }
        public int totalWarnings { get; }
        [NativeName("buildResult")]
        public BuildResult result { get; }

        public T GetSubtarget<T>() where T : Enum;
    }
}
