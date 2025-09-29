#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [ExcludeFromDocs]
    public static class ModeService
    {

        public static string[] modeNames { get; }
        public static int modeCount { get; }
        public static string currentId { get; }
        public static int currentIndex { get; }

        public static event Action<ModeChangedArgs> modeChanged;

        [RequiredByNativeCode]
        public static void ChangeModeById(string modeId);
        public static void Update();
        public static bool HasContextMenu(string menuId);
        public static void PopupContextMenu(string menuId);
        public struct ModeChangedArgs
        {

            public int prevIndex;
            public int nextIndex;
        }
    }
}
