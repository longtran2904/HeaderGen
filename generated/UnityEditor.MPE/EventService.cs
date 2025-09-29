#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.MPE
{
    [MovedFrom("Unity.MPE")]
    public static class EventService
    {

        public static bool isConnected { get; }

        public static void Start();
        public static void Close();
        public static Action RegisterEventHandler(string eventType, Action<string, object[]> handler);
        public static Action RegisterEventHandler(string eventType, Func<string, object[], object> handler);
        public static void UnregisterEventHandler(string eventType, Func<string, object[], object> handler);
        public static void Clear();
        public static void Emit(string eventType, object args = null, int targetId = -1, EventDataSerialization eventDataSerialization = EventDataSerialization.JsonUtility);
        public static void Emit(string eventType, object[] args, int targetId = -1, EventDataSerialization eventDataSerialization = EventDataSerialization.JsonUtility);
        public static bool IsRequestPending(string eventType);
        public static bool CancelRequest(string eventType, string message = null);
        public static void Request(string eventType, Action<Exception, object[]> promiseHandler, object args = null, long timeoutInMs = 700, EventDataSerialization eventDataSerialization = EventDataSerialization.JsonUtility);
        public static void Request(string eventType, Action<Exception, object[]> promiseHandler, object[] args, long timeoutInMs = 700, EventDataSerialization eventDataSerialization = EventDataSerialization.JsonUtility);
        public static void Log(string msg);
        public static void Log(string msg, LogType logType);
        public static void Tick();
    }
}
