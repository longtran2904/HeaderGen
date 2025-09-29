#region UnityEditor.DeviceSimulatorModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.DeviceSimulatorModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.DeviceSimulation
{
    public abstract class DeviceSimulatorPlugin
    {

        protected DeviceSimulatorPlugin();

        public DeviceSimulator deviceSimulator { get; }
        public abstract string title { get; }

        public virtual void OnCreate();
        public virtual void OnDestroy();
        public virtual VisualElement OnCreateUI();
    }
}
