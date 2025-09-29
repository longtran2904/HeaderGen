#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor.VersionControl
{
    [NativeType("Editor/Src/VersionControl/VCEnums.h")]
    public enum CompletionAction
    {

        UpdatePendingWindow = 1,
        OnChangeContentsPendingWindow = 2,
        OnIncomingPendingWindow = 3,
        OnChangeSetsPendingWindow = 4,
        OnGotLatestPendingWindow = 5,
        OnSubmittedChangeWindow = 6,
        OnAddedChangeWindow = 7,
        OnCheckoutCompleted = 8
    }
}
