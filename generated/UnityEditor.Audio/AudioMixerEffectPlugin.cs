#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Audio
{
    public class AudioMixerEffectPlugin : IAudioEffectPlugin
    {
        public AudioMixerEffectPlugin();

        public override bool SetFloatParameter(string name, float value);
        public override bool GetFloatParameter(string name, out float value);
        public override bool GetFloatParameterInfo(string name, out float minRange, out float maxRange, out float defaultValue);
        public override bool GetFloatBuffer(string name, out float[] data, int numsamples);
        public override int GetSampleRate();
        public override bool IsPluginEditableAndEnabled();
    }
}
