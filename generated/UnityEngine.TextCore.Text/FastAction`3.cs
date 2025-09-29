#region UnityEngine.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreTextEngineModule.dll
#endregion

using System;

namespace UnityEngine.TextCore.Text
{
    public class FastAction<A, B, C>
    {
        public FastAction();

        public void Add(Action<A, B, C> rhs);
        public void Remove(Action<A, B, C> rhs);
        public void Call(A a, B b, C c);
    }
}
