#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor
{
    public abstract class IAudioEffectPlugin
    {

        protected IAudioEffectPlugin();

        public abstract bool SetFloatParameter(string name, float value);
        public abstract bool GetFloatParameter(string name, out float value);
        public abstract bool GetFloatParameterInfo(string name, out float minRange, out float maxRange, out float defaultValue);
        public abstract bool GetFloatBuffer(string name, out float[] data, int numsamples);
        public abstract int GetSampleRate();
        public abstract bool IsPluginEditableAndEnabled();
    }
}
