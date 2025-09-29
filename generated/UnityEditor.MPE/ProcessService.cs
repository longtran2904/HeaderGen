#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.MPE
{
    [MovedFrom("Unity.MPE")]
    [NativeHeader("Modules/UMPE/ProcessService.h")]
    [StaticAccessor("Unity::MPE::ProcessService", StaticAccessorType.DoubleColon)]
    public class ProcessService
    {

        public ProcessService();

        public static ProcessLevel level { get; }
        public static string roleName { get; }

        [Obsolete("Event SlaveProcessExitedEvent was renamed. Use ProcessExitedEvent. (UnityUpgradable) -> ProcessExitedEvent")]
        public static event Action<int, ProcessState> SlaveProcessExitedEvent;
        public static event Action<int, ProcessState> ProcessExitedEvent;

        public static bool IsChannelServiceStarted();
        public static string ReadParameter(string paramName);
        [Obsolete("Function LaunchSlave was renamed. Use Launch. (UnityUpgradable) -> Launch(*)")]
        public static int LaunchSlave(string roleName, params string[] keyValuePairs);
        public static int Launch(string roleName, params string[] keyValuePairs);
        [Obsolete("Function TerminateSlave was renamed. Use Terminate. (UnityUpgradable) -> Terminate(*)")]
        public static void TerminateSlave(int pid);
        public static void Terminate(int pid);
        [Obsolete("Function GetSlaveProcessState was renamed. Use GetProcessState. (UnityUpgradable) -> GetProcessState(*)")]
        public static ProcessState GetSlaveProcessState(int pid);
        public static ProcessState GetProcessState(int pid);
        public static bool HasCapability(string capName);
        public static void ApplyPropertyModifications(PropertyModification[] modifications);
        public static byte[] SerializeObject(int instanceId);
        public static UnityEngine.Object DeserializeObject(byte[] bytes);
        public static int EnableProfileConnection(string dataPath);
        public static void DisableProfileConnection();
    }
}
