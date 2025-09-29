#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Reflection;
using UnityEngine.Bindings;

namespace UnityEngine.TestTools
{
    [NativeType(CodegenOptions.Custom, "ManagedCoveredSequencePoint", Header = "Runtime/Scripting/ScriptingCoverage.bindings.h")]
    public struct CoveredSequencePoint
    {

        public MethodBase method;
        public uint ilOffset;
        public uint hitCount;
        public string filename;
        public uint line;
        public uint column;
    }
}
