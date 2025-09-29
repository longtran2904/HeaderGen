#region Unity.VisualStudio.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.VisualStudio.Editor.dll
#endregion

using System;
using System.IO;

namespace Microsoft.Unity.VisualStudio.Editor
{
    public sealed class Image : IDisposable
    {

        public static bool IsAssembly(string file);
        public static bool IsAssembly(Stream stream);
    }
}
