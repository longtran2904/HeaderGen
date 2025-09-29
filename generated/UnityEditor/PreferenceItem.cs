#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [AttributeUsage(AttributeTargets.Method)]
    [Obsolete("[PreferenceItem] is deprecated. Use [SettingsProvider] instead.")]
    public sealed class PreferenceItem : Attribute
    {
        public string name;

        public PreferenceItem(string name);
    }
}
