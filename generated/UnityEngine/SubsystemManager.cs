#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Subsystems/SubsystemManager.h")]
    public static class SubsystemManager
    {
        public static event Action beforeReloadSubsystems;
        public static event Action afterReloadSubsystems;
        public static event Action reloadSubsytemsStarted;
        public static event Action reloadSubsytemsCompleted;

        public static void GetAllSubsystemDescriptors(List<ISubsystemDescriptor> descriptors);
        public static void GetSubsystemDescriptors<T>(List<T> descriptors) where T : ISubsystemDescriptor;
        public static void GetSubsystems<T>(List<T> subsystems) where T : ISubsystem;
        public static void GetInstances<T>(List<T> subsystems) where T : ISubsystem;
    }
}
