#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public class DropdownMenu
    {

        public DropdownMenu();

        public List<DropdownMenuItem> MenuItems();
        public void AppendAction(string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback, object userData = null);
        public void AppendAction(string actionName, Action<DropdownMenuAction> action, DropdownMenuAction.Status status = DropdownMenuAction.Status.Normal);
        public void InsertAction(int atIndex, string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback, object userData = null);
        public void InsertAction(int atIndex, string actionName, Action<DropdownMenuAction> action, DropdownMenuAction.Status status = DropdownMenuAction.Status.Normal);
        public void AppendSeparator(string subMenuPath = null);
        public void InsertSeparator(string subMenuPath, int atIndex);
        public void RemoveItemAt(int index);
        public void PrepareForDisplay(EventBase e);
    }
}
