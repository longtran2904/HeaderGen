#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Internal;

namespace UnityEditor.Licensing.UI.Events.Handlers
{
    [ExcludeFromDocs]
    public abstract class INotificationHandler
    {

        protected INotificationHandler();

        public virtual void Handle(bool isHumanControllingUs);
        public abstract void HandleUI();
        public abstract void HandleBatchmode();
    }
}
