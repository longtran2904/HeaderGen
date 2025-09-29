#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.Rendering
{
    [DebugState(new[] {typeof(DebugUI.EnumField), typeof(DebugUI.HistoryEnumField) })]
    public sealed class DebugStateEnum : DebugState<int>, ISerializationCallbackReceiver
    {

        public DebugStateEnum();

        public override void SetValue(object value, DebugUI.IValueField field);
        public void OnBeforeSerialize();
        public void OnAfterDeserialize();
    }
}
