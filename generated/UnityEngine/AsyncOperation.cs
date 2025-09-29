#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
    [NativeHeader("Runtime/Misc/AsyncOperation.h")]
    [RequiredByNativeCode]
    public class AsyncOperation : YieldInstruction
    {

        public AsyncOperation();

        ~AsyncOperation();

        public bool isDone { get; }
        public float progress { get; }
        public int priority { get; set; }
        public bool allowSceneActivation { get; set; }

        public event Action<AsyncOperation> completed;
    }
}
