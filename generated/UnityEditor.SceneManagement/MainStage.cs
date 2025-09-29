#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.SceneManagement
{
    public sealed class MainStage : Stage
    {
        public MainStage();

        protected internal override bool OnOpenStage();
        protected override void OnCloseStage();
        protected internal override GUIContent CreateHeaderContent();
    }
}
