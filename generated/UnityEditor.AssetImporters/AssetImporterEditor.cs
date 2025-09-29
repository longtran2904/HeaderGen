#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.AssetImporters
{
    [MovedFrom("UnityEditor.Experimental.AssetImporters")]
    [NativeHeader("Modules/AssetPipelineEditor/ImportSettings/AssetImporterEditorUtility.h")]
    public abstract class AssetImporterEditor : Editor
    {

        protected AssetImporterEditor();

        protected internal UnityEngine.Object[] assetTargets { get; }
        protected internal UnityEngine.Object assetTarget { get; }
        protected internal SerializedObject assetSerializedObject { get; }
        protected UnityEngine.Object[] extraDataTargets { get; }
        protected UnityEngine.Object extraDataTarget { get; }
        protected ExtraDataSerializedObject extraDataSerializedObject { get; }
        protected virtual bool needsApplyRevert { get; }
        protected virtual Type extraDataType { get; }
        protected virtual bool useAssetDrawPreview { get; }
        public virtual bool showImportedObject { get; }

        protected virtual void InitializeExtraDataInstance(UnityEngine.Object extraData, int targetIndex);
        public override void DrawPreview(Rect previewArea);
        public virtual void OnEnable();
        public virtual void OnDisable();
        protected virtual void Awake();
        public override void OnInspectorGUI();
        protected virtual void ResetValues();
        public virtual bool HasModified();
        protected virtual bool CanApply();
        protected virtual void Apply();
        protected internal void ApplyAndImport();
        protected void RevertButton();
        protected bool ApplyButton();
        protected virtual bool OnApplyRevertGUI();
        protected void ApplyRevertGUI();
        protected sealed class ExtraDataSerializedObject : SerializedObject
        {

            public void Update();
            public void UpdateIfRequiredOrScript();
            public void ApplyModifiedProperties();
            public void SetIsDifferentCacheDirty();
        }
    }
}
