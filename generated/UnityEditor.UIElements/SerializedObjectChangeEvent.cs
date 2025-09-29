#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public sealed class SerializedObjectChangeEvent : EventBase<SerializedObjectChangeEvent>
    {

        public SerializedObjectChangeEvent();

        public SerializedObject changedObject { get; set; }

        protected override void Init();
        public static SerializedObjectChangeEvent GetPooled(SerializedObject value);
    }
}
