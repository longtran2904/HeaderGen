#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [ExtensionOfNativeClass]
    [NativeClass(null)]
    [NativeHeader("Runtime/Mono/MonoBehaviour.h")]
    [RequiredByNativeCode]
    public class ScriptableObject : Object
    {
        public ScriptableObject();

        [NativeConditional("ENABLE_MONO")]
        [Obsolete("Use EditorUtility.SetDirty instead")]
        public void SetDirty();
        public static ScriptableObject CreateInstance(string className);
        public static ScriptableObject CreateInstance(Type type);
        public static T CreateInstance<T>() where T : ScriptableObject;
    }
}
