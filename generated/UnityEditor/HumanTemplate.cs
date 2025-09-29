#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [NativeType(Header = "Editor/Src/Animation/HumanTemplate.h")]
    [UsedByNativeCode]
    public sealed class HumanTemplate : UnityEngine.Object
    {
        public HumanTemplate();

        public void Insert(string name, string templateName);
        public string Find(string name);
        public void ClearTemplate();
    }
}
