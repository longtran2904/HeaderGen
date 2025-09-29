#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.TerrainTools
{
    [MovedFrom("UnityEditor.Experimental.TerrainAPI")]
    public abstract class TerrainPaintTool<T> : ScriptableSingleton<T>, ITerrainPaintTool where T : TerrainPaintTool<T>
    {
        protected TerrainPaintTool();

        public abstract string GetName();
        public abstract string GetDescription();
        public virtual void OnEnable();
        public virtual void OnDisable();
        public virtual void OnEnterToolMode();
        public virtual void OnExitToolMode();
        public virtual void OnSceneGUI(Terrain terrain, IOnSceneGUI editContext);
        public virtual void OnRenderBrushPreview(Terrain terrain, IOnSceneGUI editContext);
        public virtual void OnInspectorGUI(Terrain terrain, IOnInspectorGUI editContext);
        public virtual bool OnPaint(Terrain terrain, IOnPaint editContext);
    }
}
