#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{
    public class DefaultLightingExplorerExtension : ILightingExplorerExtension
    {

        public DefaultLightingExplorerExtension();

        public virtual LightingExplorerTab[] GetContentTabs();
        public virtual void OnEnable();
        public virtual void OnDisable();
        protected static IEnumerable<T> GetObjectsForLightingExplorer<T>() where T : Component;
        protected internal virtual UnityEngine.Object[] GetLights();
        protected internal virtual UnityEngine.Object[] Get2DLights();
        protected virtual LightingExplorerTableColumn[] Get2DLightColumns();
        protected virtual LightingExplorerTableColumn[] GetLightColumns();
        protected internal virtual UnityEngine.Object[] GetReflectionProbes();
        protected virtual LightingExplorerTableColumn[] GetReflectionProbeColumns();
        protected internal virtual UnityEngine.Object[] GetLightProbes();
        protected virtual LightingExplorerTableColumn[] GetLightProbeColumns();
        protected internal virtual UnityEngine.Object[] GetEmissives();
        protected virtual LightingExplorerTableColumn[] GetEmissivesColumns();
    }
}
