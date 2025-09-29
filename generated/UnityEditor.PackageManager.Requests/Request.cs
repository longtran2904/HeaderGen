#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.PackageManager.Requests
{
    [NativeHeader("Modules/PackageManager/Editor/Public/PackageManager.h")]
    [StaticAccessor("PackageManager", StaticAccessorType.DoubleColon)]
    public abstract class Request : ISerializationCallbackReceiver
    {
        ~Request();

        public StatusCode Status { get; }
        public bool IsCompleted { get; }
        public Error Error { get; }

        protected virtual void FetchNativeData();
    }
}
