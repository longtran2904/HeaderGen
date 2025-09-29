#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.Rendering
{
    public struct MaterialHeaderScope : IDisposable
    {

        public readonly bool expanded;

        public MaterialHeaderScope(GUIContent title, uint bitExpanded, MaterialEditor materialEditor, bool spaceAtEnd = True, bool subHeader = False, uint defaultExpandedState = 4294967295, string documentationURL = "");
        public MaterialHeaderScope(string title, uint bitExpanded, MaterialEditor materialEditor, bool spaceAtEnd = True, bool subHeader = False);
    }
}
