#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.Rendering
{
    public class MaterialHeaderScopeList
    {

        public MaterialHeaderScopeList(uint defaultExpandedState = 4294967295);

        public void RegisterHeaderScope<TEnum>(GUIContent title, TEnum expandable, Action<Material> action) where TEnum : IConvertible, struct;
        public void DrawHeaders(MaterialEditor materialEditor, Material material);
    }
}
