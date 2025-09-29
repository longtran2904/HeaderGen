#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

namespace UnityEditor.Rendering
{
    public interface ISerializedLight
    {
        LightEditor.Settings settings { get; }
        SerializedObject serializedObject { get; }
        SerializedObject serializedAdditionalDataObject { get; }
        SerializedProperty intensity { get; }

        void Update();
        void Apply();
    }
}
