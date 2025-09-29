#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditorInternal
{
    [Flags]
    public enum ProfilerMemoryRecordMode
    {

        None = 0,
        GCAlloc = 1,
        UnsafeUtilityMalloc = 2,
        JobHandleComplete = 4,
        NativeAlloc = 8
    }
}
