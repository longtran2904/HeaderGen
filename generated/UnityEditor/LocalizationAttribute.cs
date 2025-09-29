#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [AttributeUsage(AttributeTargets.Assembly)]
    [RequiredByNativeCode]
    public sealed class LocalizationAttribute : Attribute
    {
        public LocalizationAttribute(string locGroupName = null);
    }
}
