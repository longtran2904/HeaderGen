#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
    [UsedByNativeCode]
    public abstract class UnityEventBase : ISerializationCallbackReceiver
    {
        protected UnityEventBase();

        protected MethodInfo FindMethod_Impl(string name, object targetObj);
        protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType);
        public int GetPersistentEventCount();
        public Object GetPersistentTarget(int index);
        public string GetPersistentMethodName(int index);
        public void SetPersistentListenerState(int index, UnityEventCallState state);
        public UnityEventCallState GetPersistentListenerState(int index);
        protected void AddListener(object targetObj, MethodInfo method);
        protected void RemoveListener(object targetObj, MethodInfo method);
        public void RemoveAllListeners();
        protected void Invoke(object[] parameters);
        public override string ToString();
        public static MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes);
        public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes);
        protected bool ValidateRegistration(MethodInfo method, object targetObj, PersistentListenerMode mode);
        protected bool ValidateRegistration(MethodInfo method, object targetObj, PersistentListenerMode mode, Type argumentType);
        protected void RegisterPersistentListener(int index, object targetObj, MethodInfo method);
        protected void RegisterPersistentListener(int index, object targetObj, Type targetObjType, MethodInfo method);
    }
}
