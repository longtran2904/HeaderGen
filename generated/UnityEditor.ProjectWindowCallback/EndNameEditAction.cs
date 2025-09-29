#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.ProjectWindowCallback
{
    public abstract class EndNameEditAction : ScriptableObject
    {

        protected EndNameEditAction();

        public virtual void OnEnable();
        public abstract void Action(int instanceId, string pathName, string resourceFile);
        public virtual void Cancelled(int instanceId, string pathName, string resourceFile);
        public virtual void CleanUp();
    }
}
