#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Experimental.Rendering
{
    public interface IScriptableBakedReflectionSystemStageNotifier
    {

        void EnterStage(int stage, string progressMessage, float progress);
        void ExitStage(int stage);
        void SetIsDone(bool isDone);
    }
}
