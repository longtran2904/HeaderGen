#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditor.Build.Reporting
{
    [NativeType(Header = "Modules/BuildReportingEditor/Public/BuildReport.h")]
    public struct BuildStep
    {
        [NativeName("stepName")]
        public string name { get; }
        public TimeSpan duration { get; }
        public BuildStepMessage[] messages { get; }
        public int depth { get; }

        public override string ToString();
    }
}
