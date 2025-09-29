#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using System.Reflection;

namespace UnityEditor.Rendering
{
    [DefaultMember("Item")]
    public struct ExpandedState<TState, TTarget> where TState : IConvertible, struct
    {

        public ExpandedState(TState defaultValue, string prefix = "CoreRP");

        public bool this[TState mask] { get; set; }

        public bool GetExpandedAreas(TState mask);
        public void SetExpandedAreas(TState mask, bool value);
        public void ExpandAll();
        public void CollapseAll();
    }
}
