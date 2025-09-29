#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public abstract class DecoratorDrawer : GUIDrawer
    {

        protected DecoratorDrawer();

        public PropertyAttribute attribute { get; }

        public virtual void OnGUI(Rect position);
        public virtual float GetHeight();
        public virtual bool CanCacheInspectorGUI();
    }
}
