#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
    public class UnityEvent<T0, T1, T2> : UnityEventBase
    {

        [RequiredByNativeCode]
        public UnityEvent();

        public void AddListener(UnityAction<T0, T1, T2> call);
        public void RemoveListener(UnityAction<T0, T1, T2> call);
        protected override MethodInfo FindMethod_Impl(string name, Type targetObjType);
        public void Invoke(T0 arg0, T1 arg1, T2 arg2);
    }
}
