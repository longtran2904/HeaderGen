#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = False)]
    [RequiredByNativeCode]
    public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
    {
        public RuntimeInitializeOnLoadMethodAttribute();
        public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType);

        public RuntimeInitializeLoadType loadType { get; }
    }
}
