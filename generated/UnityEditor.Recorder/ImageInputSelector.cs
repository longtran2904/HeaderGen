#region Unity.Recorder.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Recorder.Editor.dll
#endregion

using UnityEditor.Recorder.Input;
using UnityEngine;

namespace UnityEditor.Recorder
{
    public class ImageInputSelector : InputSettingsSelector
    {
        [SerializeField]
        public GameViewInputSettings gameViewInputSettings;
        [SerializeField]
        public CameraInputSettings cameraInputSettings;
        [SerializeField]
        public Camera360InputSettings camera360InputSettings;
        [SerializeField]
        public RenderTextureInputSettings renderTextureInputSettings;
        [SerializeField]
        public RenderTextureSamplerSettings renderTextureSamplerSettings;

        public ImageInputSelector();

        public ImageInputSettings ImageInputSettings { get; set; }
    }
}
