#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections;

namespace UnityEngine
{
    public abstract class CustomYieldInstruction : IEnumerator
    {
        protected CustomYieldInstruction();

        public abstract bool keepWaiting { get; }
        public object Current { get; }

        public bool MoveNext();
        public virtual void Reset();
    }
}
