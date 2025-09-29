#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor
{
    public abstract class IAudioEffectPluginGUI
    {
        protected IAudioEffectPluginGUI();

        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract string Vendor { get; }

        public abstract bool OnGUI(IAudioEffectPlugin plugin);
    }
}
