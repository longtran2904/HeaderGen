#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [ExcludeFromPreset]
    [NativeHeader("Modules/AssetPipelineEditor/Public/MonoImporter.bindings.h")]
    [NativeHeader("Modules/AssetPipelineEditor/Public/MonoImporter.h")]
    public class MonoImporter : AssetImporter
    {

        public MonoImporter();

        public void SetDefaultReferences(string[] name, UnityEngine.Object[] target);
        [FreeFunction("MonoImporterBindings::GetAllRuntimeMonoScripts")]
        public static MonoScript[] GetAllRuntimeMonoScripts();
        [FreeFunction("MonoImporterBindings::SetMonoScriptExecutionOrder")]
        public static void SetExecutionOrder([NotNull("NullExceptionObject")] MonoScript script, int order);
        [FreeFunction("MonoImporterBindings::GetExecutionOrder")]
        public static int GetExecutionOrder([NotNull("NullExceptionObject")] MonoScript script);
        public MonoScript GetScript();
        public UnityEngine.Object GetDefaultReference(string name);
        public void SetIcon(Texture2D icon);
        public Texture2D GetIcon();
    }
}
