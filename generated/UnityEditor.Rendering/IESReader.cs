#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

namespace UnityEditor.Rendering
{
    public class IESReader
    {

        public IESReader();

        public string FileFormatVersion { get; }
        public float TotalLumens { get; }
        public float MaxCandelas { get; }
        public int PhotometricType { get; }

        public string ReadFile(string iesFilePath);
    }
}
