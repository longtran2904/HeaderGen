#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    [EditorWindowTitle(title = "Animation", useTypeNameAsIconName = True)]
    public sealed class AnimationWindow : EditorWindow, IHasCustomMenu
    {
        public AnimationClip animationClip { get; set; }
        public bool previewing { get; set; }
        public bool canPreview { get; }
        public bool recording { get; set; }
        public bool canRecord { get; }
        public bool playing { get; set; }
        public float time { get; set; }
        public int frame { get; set; }

        public void AddItemsToMenu(GenericMenu menu);
    }
}
