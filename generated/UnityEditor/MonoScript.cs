#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [ExcludeFromPreset]
    [NativeClass(null)]
    [NativeType("Editor/Mono/MonoScript.bindings.h")]
    public class MonoScript : TextAsset
    {

        public MonoScript();

        public Type GetClass();
        public static MonoScript FromMonoBehaviour(MonoBehaviour behaviour);
        public static MonoScript FromScriptableObject(ScriptableObject scriptableObject);
    }
}
