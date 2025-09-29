#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.VersionControl
{
    public abstract class VersionControlObject : ScriptableObject
    {

        protected VersionControlObject();

        public virtual bool isConnected { get; }

        public virtual void OnActivate();
        public virtual void OnDeactivate();
        public virtual void Refresh();
        public virtual T GetExtension<T>() where T : class;
    }
}
