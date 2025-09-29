#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace UnityEditorInternal
{
    public class ProfilerFrameDataMultiColumnHeader : MultiColumnHeader
    {
        public ProfilerFrameDataMultiColumnHeader(MultiColumnHeaderState state, Column[] columns);

        public Column[] columns { get; }
        public int sortedProfilerColumn { get; }
        public bool sortedProfilerColumnAscending { get; }

        public int GetMultiColumnHeaderIndex(int profilerColumn);
        public static int GetMultiColumnHeaderIndex(Column[] columns, int profilerColumn);
        public int GetProfilerColumn(int multiColumnHeaderIndex);

        public struct Column
        {
            public int profilerColumn;
            public GUIContent headerLabel;
        }
    }
}
