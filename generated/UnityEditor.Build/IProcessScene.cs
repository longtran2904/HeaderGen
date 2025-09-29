#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.SceneManagement;

namespace UnityEditor.Build
{
    [Obsolete("Use IProcessSceneWithReport instead")]
    public interface IProcessScene : IOrderedCallback
    {
        void OnProcessScene(Scene scene);
    }
}
