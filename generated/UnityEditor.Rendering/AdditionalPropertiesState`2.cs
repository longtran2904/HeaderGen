#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using System.Reflection;

namespace UnityEditor.Rendering
{
    [DefaultMember("Item")]
    public class AdditionalPropertiesState<TState, TTarget> where TState : IConvertible, struct
    {

        public AdditionalPropertiesState(TState defaultValue, string prefix = "CoreRP");

        public bool this[TState mask] { get; set; }

        public bool GetAdditionalPropertiesState(TState mask);
        public void SetAdditionalPropertiesState(TState mask, bool value);
        public void ShowAll();
        public void HideAll();
        public void RegisterEditor(Editor editor);
        public void UnregisterEditor(Editor editor);
    }
}
