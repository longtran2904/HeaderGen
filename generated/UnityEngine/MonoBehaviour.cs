#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [ExtensionOfNativeClass]
    [NativeHeader("Runtime/Scripting/DelayedCallUtility.h")]
    [NativeHeader("Runtime/Mono/MonoBehaviour.h")]
    [RequiredByNativeCode]
    public class MonoBehaviour : Behaviour
    {

        public MonoBehaviour();

        public bool useGUILayout { get; set; }
        public bool runInEditMode { get; set; }

        public bool IsInvoking();
        public void CancelInvoke();
        public void Invoke(string methodName, float time);
        public void InvokeRepeating(string methodName, float time, float repeatRate);
        public void CancelInvoke(string methodName);
        public bool IsInvoking(string methodName);
        [ExcludeFromDocs]
        public Coroutine StartCoroutine(string methodName);
        public Coroutine StartCoroutine(string methodName, [DefaultValue("null")] object value);
        public Coroutine StartCoroutine(IEnumerator routine);
        [Obsolete("StartCoroutine_Auto has been deprecated. Use StartCoroutine instead (UnityUpgradable) -> StartCoroutine([mscorlib] System.Collections.IEnumerator)", False)]
        public Coroutine StartCoroutine_Auto(IEnumerator routine);
        public void StopCoroutine(IEnumerator routine);
        public void StopCoroutine(Coroutine routine);
        public void StopCoroutine(string methodName);
        public void StopAllCoroutines();
        public static void print(object message);
    }
}
