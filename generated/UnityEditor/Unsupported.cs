#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.SceneManagement;

namespace UnityEditor
{
    [NativeHeader("Editor/Mono/Unsupported.bindings.h")]
    public static class Unsupported
    {

        [StaticAccessor("GetRenderManager()", StaticAccessorType.Dot)]
        public static bool useScriptableRenderPipeline { get; set; }
        public static bool IsRegistryValidationDisabled { get; set; }

        [FreeFunction]
        public static void CaptureScreenshotImmediate(string filePath, int x, int y, int width, int height);
        [FreeFunction("MenuController::ExtractSubmenusCommands")]
        public static string[] GetSubmenusCommands(string menuPath);
        public static Type GetTypeFromFullName(string fullName);
        public static string[] GetSubmenus(string menuPath);
        public static string[] GetSubmenusIncludingSeparators(string menuPath);
        public static void PrepareObjectContextMenu(UnityEngine.Object c, int contextUserData);
        public static bool IsDeveloperBuild();
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsDeveloperMode();
        public static bool IsSourceBuild();
        [FreeFunction(IsThreadSafe = True)]
        public static bool IsSourceBuild(bool checkHumanControllingUs);
        public static bool IsBleedingEdgeBuild();
        public static bool IsDestroyScriptableObject(ScriptableObject target);
        public static bool IsNativeCodeBuiltInReleaseMode();
        [FreeFunction(IsThreadSafe = True)]
        public static string GetBaseUnityDeveloperFolder();
        public static void StopPlayingImmediately();
        [FreeFunction("GetSceneTracker().FlushDirty")]
        public static void SceneTrackerFlushDirty();
        [FreeFunction("GetScreenManager().SetAllowCursorHide")]
        public static void SetAllowCursorHide(bool allow);
        [Obsolete("This method has been marked obsolete, use SetOverrideLightingSettings instead (UnityUpgradable) -> SetOverrideLightingSettings(*)", True)]
        public static bool SetOverrideRenderSettings(Scene scene);
        [Obsolete("This method has been marked obsolete, use RestoreOverrideLightingSettings instead (UnityUpgradable) -> RestoreOverrideLightingSettings(*)", True)]
        public static void RestoreOverrideRenderSettings();
        public static bool SetOverrideLightingSettings(Scene scene);
        [NativeThrows]
        public static void RestoreOverrideLightingSettings();
        [FreeFunction("GetRenderSettings().SetUseFogNoDirty")]
        public static void SetRenderSettingsUseFogNoDirty(bool fog);
        [FreeFunction("GetRenderSettings().SetSceneViewDebugModeExposureNoDirty")]
        public static void SetSceneViewDebugModeExposureNoDirty(float exposure);
        [FreeFunction("GetQualitySettings().SetShadowDistanceTemporarily")]
        public static void SetQualitySettingsShadowDistanceTemporarily(float distance);
        [FreeFunction("DeleteGameObjectSelection")]
        public static void DeleteGameObjectSelection();
        [FreeFunction]
        public static void CopyGameObjectsToPasteboard();
        public static void PasteGameObjectsFromPasteboard();
        [FreeFunction("AssetDatabase::GetSingletonAsset")]
        public static UnityEngine.Object GetSerializedAssetInterfaceSingleton(string className);
        [FreeFunction]
        public static void DuplicateGameObjectsUsingPasteboard();
        [FreeFunction]
        public static bool CopyComponentToPasteboard(Component component);
        [FreeFunction]
        public static bool PasteComponentFromPasteboard(GameObject go);
        [FreeFunction]
        public static bool PasteComponentValuesFromPasteboard(Component component);
        [FreeFunction("UnityEditor::StateMachineTransitionCopyPaste::HasParametersInPasteboard")]
        public static bool HasStateMachineTransitionDataInPasteboard();
        public static bool AreAllParametersInDestination(UnityEngine.Object transition, AnimatorController controller, List<string> missingParameters);
        public static bool DestinationHasCompatibleParameterTypes(UnityEngine.Object transition, AnimatorController controller, List<string> mismatchedParameters);
        public static bool CanPasteParametersToTransition(UnityEngine.Object transition, AnimatorController controller);
        [FreeFunction("UnityEditor::StateMachineTransitionCopyPaste::CopyParametersToPasteboard")]
        public static void CopyStateMachineTransitionParametersToPasteboard(UnityEngine.Object transition, AnimatorController controller);
        public static void PasteToStateMachineTransitionParametersFromPasteboard(UnityEngine.Object transition, AnimatorController controller, bool conditions, bool parameters);
        public static void CopyStateMachineDataToPasteboard(UnityEngine.Object stateMachineObject, AnimatorController controller, int layerIndex);
        public static void PasteToStateMachineFromPasteboard(AnimatorStateMachine sm, AnimatorController controller, int layerIndex, Vector3 position);
        [FreeFunction("UnityEditor::StateMachineCopyPaste::HasDataInPasteboard")]
        public static bool HasStateMachineDataInPasteboard();
        [FreeFunction("SmartResetObject")]
        public static void SmartReset([NotNull("NullExceptionObject")] UnityEngine.Object obj);
        [FreeFunction("ResolveSymlinks")]
        public static string ResolveSymlinks(string path);
        [FreeFunction("GetPhysicalPath")]
        public static string ResolveRedirectedPath(string path);
        [FreeFunction("AssetDatabaseDeprecated::SetApplicationSettingCompressAssetsOnImport")]
        public static void SetApplicationSettingCompressAssetsOnImport(bool value);
        [StaticAccessor("AssetDatabaseDeprecated", StaticAccessorType.DoubleColon)]
        public static bool GetApplicationSettingCompressAssetsOnImport();
        [FreeFunction("GetPersistentManager().GetLocalFileID")]
        [Obsolete("GetLocalIdentifierInFile() is deprecated. Use GetLocalIdentifierInFileForPersistentObject() instead.", False)]
        public static int GetLocalIdentifierInFile(int instanceID);
        public static ulong GetLocalIdentifierInFileForPersistentObject(UnityEngine.Object obj);
        [FreeFunction]
        public static bool IsHiddenFile(string path);
        [FreeFunction]
        public static void ClearSkinCache();
        public static UnityEngine.Object GetRenderSettings();
    }
}
