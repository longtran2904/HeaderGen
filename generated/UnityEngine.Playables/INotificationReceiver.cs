#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
    [RequiredByNativeCode]
    public interface INotificationReceiver
    {

        [RequiredByNativeCode]
        void OnNotify(Playable origin, INotification notification, object context);
    }
}
