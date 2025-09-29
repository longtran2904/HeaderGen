#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Profiling
{
    [NativeHeader("Runtime/Profiler/ScriptBindings/Sampler.bindings.h")]
    [UsedByNativeCode]
    public class Sampler
    {

        public bool isValid { get; }
        public string name { get; }

        public Recorder GetRecorder();
        public static Sampler Get(string name);
        public static int GetNames(List<string> names);
    }
}
