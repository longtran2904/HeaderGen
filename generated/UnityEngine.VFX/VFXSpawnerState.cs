#region UnityEngine.VFXModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VFXModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
    [NativeType(Header = "Modules/VFX/Public/VFXSpawnerState.h")]
    [RequiredByNativeCode]
    public sealed class VFXSpawnerState : IDisposable
    {
        public VFXSpawnerState();

        ~VFXSpawnerState();

        public bool playing { get; set; }
        public bool newLoop { get; }
        public VFXSpawnerLoopState loopState { get; set; }
        public float spawnCount { get; set; }
        public float deltaTime { get; set; }
        public float totalTime { get; set; }
        public float delayBeforeLoop { get; set; }
        public float loopDuration { get; set; }
        public float delayAfterLoop { get; set; }
        public int loopIndex { get; set; }
        public int loopCount { get; set; }
        public VFXEventAttribute vfxEventAttribute { get; }

        public void Dispose();
    }
}
