#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditor.Scripting
{
    [InitializeOnLoad]
    [NativeHeader("Editor/Src/Scripting/ManagedDebugger.h")]
    public sealed class ManagedDebugger
    {

        public ManagedDebugger();

        public static bool isAttached { get; }
        public static bool isEnabled { get; }

        public static event Action<bool> debuggerAttached;

        [FreeFunction(Name = "ManagedDebugger::Disconnect")]
        public static void Disconnect();
    }
}
