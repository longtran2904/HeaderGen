#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.PackageManager
{
    public static class Events
    {
        public static event Action<PackageRegistrationEventArgs> registeringPackages;
        public static event Action<PackageRegistrationEventArgs> registeredPackages;
    }
}
