#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor
{
    [MovedFrom("UnityEditor.LinuxStandalone")]
    public abstract class Sysroot
    {
        protected Sysroot();

        public abstract string Name { get; }
        public abstract string HostPlatform { get; }
        public abstract string HostArch { get; }
        public abstract string TargetPlatform { get; }
        public abstract string TargetArch { get; }

        public abstract bool Initialize();
        public abstract IEnumerable<string> GetIl2CppArguments();
    }
}
