#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.Experimental.Rendering
{
    public interface IScriptableBakedReflectionSystem : IDisposable
    {
        int stageCount { get; }
        Hash128[] stateHashes { get; }

        void Tick(SceneStateHash sceneStateHash, IScriptableBakedReflectionSystemStageNotifier handle);
        void SynchronizeReflectionProbes();
        void Clear();
        void Cancel();
        bool BakeAllReflectionProbes();
    }
}
