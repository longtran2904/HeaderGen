#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Events;

namespace UnityEditor.Events
{
    public static class UnityEventTools
    {

        public static void AddPersistentListener(UnityEventBase unityEvent);
        public static void RemovePersistentListener(UnityEventBase unityEvent, int index);
        public static void AddPersistentListener(UnityEvent unityEvent, UnityAction call);
        public static void AddPersistentListener<T0>(UnityEvent<T0> unityEvent, UnityAction<T0> call);
        public static void AddPersistentListener<T0, T1>(UnityEvent<T0, T1> unityEvent, UnityAction<T0, T1> call);
        public static void AddPersistentListener<T0, T1, T2>(UnityEvent<T0, T1, T2> unityEvent, UnityAction<T0, T1, T2> call);
        public static void AddPersistentListener<T0, T1, T2, T3>(UnityEvent<T0, T1, T2, T3> unityEvent, UnityAction<T0, T1, T2, T3> call);
        public static void RegisterPersistentListener(UnityEvent unityEvent, int index, UnityAction call);
        public static void RegisterPersistentListener<T0>(UnityEvent<T0> unityEvent, int index, UnityAction<T0> call);
        public static void RegisterPersistentListener<T0, T1>(UnityEvent<T0, T1> unityEvent, int index, UnityAction<T0, T1> call);
        public static void RegisterPersistentListener<T0, T1, T2>(UnityEvent<T0, T1, T2> unityEvent, int index, UnityAction<T0, T1, T2> call);
        public static void RegisterPersistentListener<T0, T1, T2, T3>(UnityEvent<T0, T1, T2, T3> unityEvent, int index, UnityAction<T0, T1, T2, T3> call);
        public static void RemovePersistentListener(UnityEventBase unityEvent, UnityAction call);
        public static void RemovePersistentListener<T0>(UnityEventBase unityEvent, UnityAction<T0> call);
        public static void RemovePersistentListener<T0, T1>(UnityEventBase unityEvent, UnityAction<T0, T1> call);
        public static void RemovePersistentListener<T0, T1, T2>(UnityEventBase unityEvent, UnityAction<T0, T1, T2> call);
        public static void RemovePersistentListener<T0, T1, T2, T3>(UnityEventBase unityEvent, UnityAction<T0, T1, T2, T3> call);
        public static void UnregisterPersistentListener(UnityEventBase unityEvent, int index);
        public static void AddVoidPersistentListener(UnityEventBase unityEvent, UnityAction call);
        public static void RegisterVoidPersistentListener(UnityEventBase unityEvent, int index, UnityAction call);
        public static void AddIntPersistentListener(UnityEventBase unityEvent, UnityAction<int> call, int argument);
        public static void RegisterIntPersistentListener(UnityEventBase unityEvent, int index, UnityAction<int> call, int argument);
        public static void AddFloatPersistentListener(UnityEventBase unityEvent, UnityAction<float> call, float argument);
        public static void RegisterFloatPersistentListener(UnityEventBase unityEvent, int index, UnityAction<float> call, float argument);
        public static void AddBoolPersistentListener(UnityEventBase unityEvent, UnityAction<bool> call, bool argument);
        public static void RegisterBoolPersistentListener(UnityEventBase unityEvent, int index, UnityAction<bool> call, bool argument);
        public static void AddStringPersistentListener(UnityEventBase unityEvent, UnityAction<string> call, string argument);
        public static void RegisterStringPersistentListener(UnityEventBase unityEvent, int index, UnityAction<string> call, string argument);
        public static void AddObjectPersistentListener<T>(UnityEventBase unityEvent, UnityAction<T> call, T argument) where T : UnityEngine.Object;
        public static void RegisterObjectPersistentListener<T>(UnityEventBase unityEvent, int index, UnityAction<T> call, T argument) where T : UnityEngine.Object;
    }
}
