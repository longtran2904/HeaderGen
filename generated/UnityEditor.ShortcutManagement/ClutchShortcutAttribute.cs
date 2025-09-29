#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine;

namespace UnityEditor.ShortcutManagement
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ClutchShortcutAttribute : ShortcutAttribute
    {

        public ClutchShortcutAttribute(string id, [DefaultValue("null")] Type context = null);
        public ClutchShortcutAttribute(string id, Type context, KeyCode defaultKeyCode, [DefaultValue("None")] ShortcutModifiers defaultShortcutModifiers = ShortcutModifiers.None);
        public ClutchShortcutAttribute(string id, KeyCode defaultKeyCode, [DefaultValue("None")] ShortcutModifiers defaultShortcutModifiers = ShortcutModifiers.None);
    }
}
