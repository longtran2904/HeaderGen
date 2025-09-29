#region Unity.VisualStudio.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.VisualStudio.Editor.dll
#endregion

namespace Microsoft.Unity.VisualStudio.Editor
{
    public interface IFileIO
    {

        bool Exists(string fileName);
        string ReadAllText(string fileName);
        void WriteAllText(string fileName, string content);
    }
}
