#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public class DropdownMenuAction : DropdownMenuItem
    {
        public DropdownMenuAction(string actionName, Action<DropdownMenuAction> actionCallback, Func<DropdownMenuAction, Status> actionStatusCallback, object userData = null);

        public string name { get; }
        public Status status { get; }
        public DropdownMenuEventInfo eventInfo { get; }
        public object userData { get; }

        public static Status AlwaysEnabled(DropdownMenuAction a);
        public static Status AlwaysDisabled(DropdownMenuAction a);
        public void UpdateActionStatus(DropdownMenuEventInfo eventInfo);
        public void Execute();

        [Flags]
        public enum Status
        {
            None = 0,
            Normal = 1,
            Disabled = 2,
            Checked = 4,
            Hidden = 8
        }
    }
}
