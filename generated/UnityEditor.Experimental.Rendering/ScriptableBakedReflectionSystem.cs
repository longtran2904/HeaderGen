#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.Experimental.Rendering
{
    public abstract class ScriptableBakedReflectionSystem : IDisposable, IScriptableBakedReflectionSystem
    {

        protected ScriptableBakedReflectionSystem(int stageCount);

        public int stageCount { get; }
        public Hash128[] stateHashes { get; protected set; }

        public virtual void Tick(SceneStateHash sceneStateHash, IScriptableBakedReflectionSystemStageNotifier handle);
        public virtual void SynchronizeReflectionProbes();
        public virtual void Clear();
        public virtual void Cancel();
        public virtual bool BakeAllReflectionProbes();
        protected virtual void Dispose(bool disposing);
    }
}
