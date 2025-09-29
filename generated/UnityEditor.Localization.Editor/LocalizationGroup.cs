#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.Localization.Editor
{
    [Obsolete("LocalizationGroup has been deprecated. Please use UnityEditor.LocalizationGroup instead", True)]
    public class LocalizationGroup : IDisposable
    {

        public LocalizationGroup();
        public LocalizationGroup(Behaviour behaviour);
        public LocalizationGroup(Type type);
        public LocalizationGroup(object obj);

        public string locGroupName { get; }

        public void Dispose();
    }
}
