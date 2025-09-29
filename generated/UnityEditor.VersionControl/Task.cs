#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.VersionControl
{
    [NativeHeader("Editor/Src/VersionControl/VCTask.h")]
    [NativeHeader("Editor/Src/VersionControl/VC_bindings.h")]
    [UsedByNativeCode]
    public class Task
    {
        ~Task();

        public int userIdentifier { get; set; }
        public string text { get; }
        public string description { get; }
        public bool success { get; }
        public int secondsSpent { get; }
        public int progressPct { get; }
        public string progressMessage { get; }
        public int resultCode { get; }
        public Message[] messages { get; }
        public AssetList assetList { get; }
        public ChangeSets changeSets { get; }

        public void Wait();
        public void SetCompletionAction(CompletionAction action);
        public void Dispose();
    }
}
