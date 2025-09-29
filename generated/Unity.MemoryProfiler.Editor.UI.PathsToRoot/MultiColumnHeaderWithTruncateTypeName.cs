#region Unity.MemoryProfiler.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.MemoryProfiler.Editor.dll
#endregion

using System;
using UnityEditor;
using UnityEditor.IMGUI.Controls;

namespace Unity.MemoryProfiler.Editor.UI.PathsToRoot
{
    public class MultiColumnHeaderWithTruncateTypeName : MultiColumnHeader
    {

        public MultiColumnHeaderWithTruncateTypeName(MultiColumnHeaderState state);

        public event Action<bool> TruncationChangedViaThisHeader;

        protected override void AddColumnHeaderContextMenuItems(GenericMenu menu);
    }
}
