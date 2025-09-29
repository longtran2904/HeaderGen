#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Experimental.Rendering
{
    public abstract class ScriptableRuntimeReflectionSystem : IDisposable, IScriptableRuntimeReflectionSystem
    {
        protected ScriptableRuntimeReflectionSystem();

        public virtual bool TickRealtimeProbes();
        protected virtual void Dispose(bool disposing);
    }
}
