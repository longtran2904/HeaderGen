#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

namespace UnityEditor.Rendering
{
    public interface ISerializedCamera
    {

        SerializedObject serializedObject { get; }
        SerializedObject serializedAdditionalDataObject { get; }
        CameraEditor.Settings baseCameraSettings { get; }
        SerializedProperty projectionMatrixMode { get; }
        SerializedProperty dithering { get; }
        SerializedProperty stopNaNs { get; }
        SerializedProperty allowDynamicResolution { get; }
        SerializedProperty volumeLayerMask { get; }
        SerializedProperty clearDepth { get; }
        SerializedProperty antialiasing { get; }

        void Update();
        void Apply();
        void Refresh();
    }
}
