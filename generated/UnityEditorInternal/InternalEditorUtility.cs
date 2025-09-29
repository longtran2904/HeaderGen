#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditorInternal
{
    [NativeHeader("Runtime/BaseClasses/TagManager.h")]
    [NativeHeader("Editor/Src/RemoteInput/RemoteInput.h")]
    [NativeHeader("Editor/Src/Undo/ObjectUndo.h")]
    [NativeHeader("Modules/AssetDatabase/Editor/Public/AssetDatabaseProperty.h")]
    [NativeHeader("Editor/Src/Utility/CustomLighting.h")]
    [NativeHeader("Editor/Src/Utility/DiffTool.h")]
    [NativeHeader("Editor/Src/Utility/GameObjectHierarchyProperty.h")]
    [NativeHeader("Editor/Src/ShaderMenu.h")]
    [NativeHeader("Modules/AssetDatabase/Editor/Public/AssetDatabase.h")]
    [NativeHeader("Runtime/Camera/RenderSettings.h")]
    [NativeHeader("Runtime/Camera/RenderManager.h")]
    [NativeHeader("Runtime/Interfaces/ILicensing.h")]
    [NativeHeader("Runtime/Camera/Skybox.h")]
    [NativeHeader("Runtime/Transform/RectTransform.h")]
    [NativeHeader("Runtime/Graphics/Renderer.h")]
    [NativeHeader("Runtime/Graphics/ScreenManager.h")]
    [NativeHeader("Runtime/Graphics/SpriteFrame.h")]
    [NativeHeader("Runtime/Camera/Camera.h")]
    [NativeHeader("Editor/Src/LoadFileAndForgetOperation.h")]
    [NativeHeader("Editor/Src/EditorModules.h")]
    [NativeHeader("Editor/Src/HierarchyState.h")]
    [NativeHeader("Editor/Mono/MonoEditorUtility.h")]
    [NativeHeader("Editor/Src/InternalEditorUtility.bindings.h")]
    [NativeHeader("Editor/Src/Application/Application.h")]
    [NativeHeader("Modules/AssetDatabase/Editor/Public/AssetDatabaseDeprecated.h")]
    [NativeHeader("Editor/Src/AssetPipeline/TextureImporting/BumpMapSettings.h")]
    [NativeHeader("Editor/Src/ScriptCompilation/PrecompiledAssemblies.h")]
    [NativeHeader("Editor/Src/AssetPipeline/ObjectHashGenerator.h")]
    [NativeHeader("Editor/Src/InspectorExpandedState.h")]
    [NativeHeader("Editor/Src/AssetPipeline/UnityExtensions.h")]
    [NativeHeader("Editor/Src/DisplayDialog.h")]
    [NativeHeader("Editor/Src/DragAndDropForwarding.h")]
    [NativeHeader("Editor/Src/EditorHelper.h")]
    [NativeHeader("Editor/Src/EditorUserBuildSettings.h")]
    [NativeHeader("Editor/Src/EditorWindowController.h")]
    [NativeHeader("Runtime/2D/Common/SpriteTypes.h")]
    [NativeHeader("Editor/Src/Gizmos/GizmoUtil.h")]
    [NativeHeader("Editor/Src/AuxWindowManager.h")]
    [NativeHeader("Editor/Platform/Interface/ColorPicker.h")]
    [NativeHeader("Runtime/Graphics/GraphicsHelper.h")]
    [NativeHeader("Runtime/Input/Cursor.h")]
    [NativeHeader("Runtime/Graphics/GpuDeviceManager.h")]
    [NativeHeader("Runtime/Utilities/UnityConfiguration.h")]
    [NativeHeader("Runtime/Utilities/LaunchUtilities.h")]
    [NativeHeader("Runtime/Utilities/FileUtilities.h")]
    [NativeHeader("Runtime/Utilities/Argv.h")]
    [NativeHeader("Editor/Src/BuildPipeline/BuildTargetPlatformSpecific.h")]
    [NativeHeader("Editor/Src/BuildPipeline/BuildPlayer.h")]
    [NativeHeader("Editor/Platform/Interface/EditorUtility.h")]
    [NativeHeader("Runtime/Threads/ThreadChecks.h")]
    [NativeHeader("Runtime/Misc/GameObjectUtility.h")]
    [NativeHeader("Runtime/Misc/Player.h")]
    [NativeHeader("Runtime/Misc/PlayerSettings.h")]
    [NativeHeader("Runtime/Utilities/Word.h")]
    [NativeHeader("Runtime/Serialize/PersistentManager.h")]
    [NativeHeader("Runtime/Shaders/ShaderImpl/FastPropertyName.h")]
    [NativeHeader("Runtime/Serialize/PersistentManager.h")]
    public class InternalEditorUtility
    {

        public InternalEditorUtility();

        public static bool isHumanControllingUs { get; }
        public static bool isApplicationActive { get; }
        public static bool inBatchMode { get; }
        public static int[] expandedProjectWindowItems { get; set; }
        public static string[] tags { get; }
        public static string[] layers { get; }
        public static string unityPreferencesFolder { get; }
        [NativeProperty("defaultScreenWidth", TargetType.Field)]
        [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
        public static float defaultScreenWidth { get; }
        [NativeProperty("defaultScreenHeight", TargetType.Field)]
        [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
        public static float defaultScreenHeight { get; }
        [NativeProperty("defaultWebScreenWidth", TargetType.Field)]
        [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
        public static float defaultWebScreenWidth { get; }
        [NativeProperty("defaultWebScreenHeight", TargetType.Field)]
        [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
        public static float defaultWebScreenHeight { get; }
        public static float remoteScreenWidth { get; }
        public static float remoteScreenHeight { get; }

        [NativeMethod("PerformUnmarkedBumpMapTexturesFixingAfterDialog")]
        [StaticAccessor("BumpMapSettings::Get()", StaticAccessorType.Dot)]
        public static void BumpMapSettingsFixingWindowReportResult(int result);
        [NativeMethod("PerformUnmarkedBumpMapTexturesFixing")]
        [StaticAccessor("BumpMapSettings::Get()", StaticAccessorType.Dot)]
        public static bool PerformUnmarkedBumpMapTexturesFixing();
        [FreeFunction("InternalEditorUtilityBindings::BumpMapTextureNeedsFixingInternal")]
        public static bool BumpMapTextureNeedsFixingInternal([NotNull("NullExceptionObject")] Material material, string propName, bool flaggedAsNormal);
        [FreeFunction("InternalEditorUtilityBindings::FixNormalmapTextureInternal")]
        public static void FixNormalmapTextureInternal([NotNull("ArgumentNullException")] Material material, string propName);
        [FreeFunction("InternalEditorUtilityBindings::GetEditorAssemblyPath")]
        public static string GetEditorAssemblyPath();
        [FreeFunction("InternalEditorUtilityBindings::GetEngineAssemblyPath")]
        public static string GetEngineAssemblyPath();
        [FreeFunction("InternalEditorUtilityBindings::GetEngineCoreModuleAssemblyPath")]
        public static string GetEngineCoreModuleAssemblyPath();
        [FreeFunction("InternalEditorUtilityBindings::CalculateHashForObjectsAndDependencies")]
        public static string CalculateHashForObjectsAndDependencies(UnityEngine.Object[] objects);
        [FreeFunction]
        public static void ExecuteCommandOnKeyWindow(string commandName);
        [FreeFunction("InternalEditorUtilityBindings::InstantiateMaterialsInEditMode")]
        public static Material[] InstantiateMaterialsInEditMode([NotNull("ArgumentNullException")] Renderer renderer);
        [Obsolete("BuildCanBeAppended has been deprecated. Use UnityEditor.BuildPipeline.BuildCanBeAppended instead (UnityUpgradable) -> [UnityEditor] UnityEditor.BuildPipeline.BuildCanBeAppended(*)", True)]
        public static CanAppendBuild BuildCanBeAppended(BuildTarget target, string location);
        [Obsolete("RequestScriptReload has been deprecated. Use UnityEditor.EditorUtility.RequestScriptReload instead (UnityUpgradable) -> [UnityEditor] UnityEditor.EditorUtility.RequestScriptReload(*)")]
        public static void RequestScriptReload();
        [NativeMethod("SwitchSkinAndRepaintAllViews")]
        [StaticAccessor("GetApplication()", StaticAccessorType.Dot)]
        public static void SwitchSkinAndRepaintAllViews();
        [NativeMethod("RequestRepaintAllViews")]
        [StaticAccessor("GetApplication()", StaticAccessorType.Dot)]
        public static void RepaintAllViews();
        [NativeMethod("IsInspectorExpanded")]
        [StaticAccessor("GetInspectorExpandedState()", StaticAccessorType.Dot)]
        public static bool GetIsInspectorExpanded(UnityEngine.Object obj);
        [NativeMethod("SetInspectorExpanded")]
        [StaticAccessor("GetInspectorExpandedState()", StaticAccessorType.Dot)]
        public static void SetIsInspectorExpanded(UnityEngine.Object obj, bool isExpanded);
        public static Assembly LoadAssemblyWrapper(string dllName, string dllLocation);
        public static void SaveToSerializedFileAndForget(UnityEngine.Object[] obj, string path, bool allowTextSerialization);
        [FreeFunction("InternalEditorUtilityBindings::LoadSerializedFileAndForget")]
        public static UnityEngine.Object[] LoadSerializedFileAndForget(string path);
        [FreeFunction("LoadFileAndForgetOperation::LoadSerializedFileAndForgetAsync")]
        public static LoadFileAndForgetOperation LoadSerializedFileAndForgetAsync(string path, long localIdentifierInFile, ulong offsetInFile = 0, long fileSize = -1);
        [FreeFunction("InternalEditorUtilityBindings::ProjectWindowDrag")]
        public static DragAndDropVisualMode ProjectWindowDrag(HierarchyProperty property, bool perform);
        [FreeFunction("InternalEditorUtilityBindings::HierarchyWindowDrag")]
        public static DragAndDropVisualMode HierarchyWindowDrag(HierarchyProperty property, HierarchyDropFlags dropMode, Transform parentForDraggedObjects, bool perform);
        [FreeFunction("InternalEditorUtilityBindings::HierarchyWindowDragByID")]
        public static DragAndDropVisualMode HierarchyWindowDragByID(int dropTargetInstanceID, HierarchyDropFlags dropMode, Transform parentForDraggedObjects, bool perform);
        [FreeFunction("InternalEditorUtilityBindings::SceneViewDrag")]
        public static DragAndDropVisualMode SceneViewDrag(UnityEngine.Object dropUpon, Vector3 worldPosition, Vector2 viewportPosition, Transform parentForDraggedObjects, bool perform);
        [FreeFunction("InternalEditorUtilityBindings::SetRectTransformTemporaryRect")]
        public static void SetRectTransformTemporaryRect([NotNull("ArgumentNullException")] RectTransform rectTransform, Rect rect);
        [Obsolete("HasTeamLicense always returns true, no need to call it")]
        public static bool HasTeamLicense();
        [FreeFunction("InternalEditorUtilityBindings::HasPro", IsThreadSafe = True)]
        public static bool HasPro();
        [FreeFunction("InternalEditorUtilityBindings::HasFreeLicense", IsThreadSafe = True)]
        public static bool HasFreeLicense();
        [FreeFunction("InternalEditorUtilityBindings::HasEduLicense", IsThreadSafe = True)]
        public static bool HasEduLicense();
        [FreeFunction]
        public static bool HasAdvancedLicenseOnBuildTarget(BuildTarget target);
        public static bool IsMobilePlatform(BuildTarget target);
        [FreeFunction("InternalEditorUtilityBindings::GetBoundsOfDesktopAtPoint")]
        [NativeThrows]
        public static Rect GetBoundsOfDesktopAtPoint(Vector2 pos);
        [NativeMethod("RemoveTag")]
        [StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
        public static void RemoveTag(string tag);
        [FreeFunction("InternalEditorUtilityBindings::AddTag")]
        public static void AddTag(string tag);
        public static LayerMask ConcatenatedLayersMaskToLayerMask(int concatenatedLayersMask);
        [FreeFunction("TryOpenErrorFileFromConsole")]
        public static bool TryOpenErrorFileFromConsole(string path, int line, int column);
        public static bool TryOpenErrorFileFromConsole(string path, int line);
        public static int LayerMaskToConcatenatedLayersMask(LayerMask mask);
        [FreeFunction("InternalEditorUtilityBindings::GetSpriteOuterUV")]
        public static Vector4 GetSpriteOuterUV([NotNull("ArgumentNullException")] Sprite sprite, bool getAtlasData);
        [FreeFunction("PPtr<Object>")]
        public static UnityEngine.Object GetObjectFromInstanceID(int instanceID);
        [FreeFunction("GetTypeWithoutLoadingObject")]
        public static Type GetTypeWithoutLoadingObject(int instanceID);
        [FreeFunction("Object::IDToPointer")]
        public static UnityEngine.Object GetLoadedObjectFromInstanceID(int instanceID);
        [NativeMethod("LayerToString")]
        [StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
        public static string GetLayerName(int layer);
        [FreeFunction]
        public static string GetAssetsFolder();
        [FreeFunction]
        public static string GetEditorFolder();
        [FreeFunction]
        public static bool IsInEditorFolder(string path);
        public static void ReloadWindowLayoutMenu();
        public static void RevertFactoryLayoutSettings(bool quitOnCancel);
        public static void LoadDefaultLayout();
        [FreeFunction("SetupShaderPopupMenu")]
        [Obsolete("SetupShaderMenu is obsolete. You can get list of available shaders with ShaderUtil.GetAllShaderInfos", False)]
        public static void SetupShaderMenu([NotNull("ArgumentNullException")] Material material);
        [FreeFunction("UnityConfig::GetUnityBuildFullVersion")]
        public static string GetFullUnityVersion();
        public static Version GetUnityVersion();
        [FreeFunction("InternalEditorUtilityBindings::GetUnityVersionDigits")]
        public static string GetUnityVersionDigits();
        [FreeFunction("UnityConfig::GetUnityBuildBranchName")]
        public static string GetUnityBuildBranch();
        [FreeFunction("UnityConfig::GetUnityBuildHash")]
        public static string GetUnityBuildHash();
        [FreeFunction("UnityConfig::GetUnityDisplayVersion")]
        public static string GetUnityDisplayVersion();
        [FreeFunction("UnityConfig::GetUnityDisplayVersionVerbose")]
        public static string GetUnityDisplayVersionVerbose();
        [FreeFunction("UnityConfig::GetUnityBuildTimeSinceEpoch")]
        public static int GetUnityVersionDate();
        [FreeFunction("UnityConfig::GetUnityBuildNumericRevision")]
        public static int GetUnityRevision();
        [FreeFunction("InternalEditorUtilityBindings::IsUnityBeta")]
        public static bool IsUnityBeta();
        [FreeFunction("InternalEditorUtilityBindings::GetUnityCopyright")]
        public static string GetUnityCopyright();
        [FreeFunction("InternalEditorUtilityBindings::GetLicenseInfoText")]
        public static string GetLicenseInfo();
        [FreeFunction("InternalEditorUtilityBindings::GetLicenseFlags")]
        public static int[] GetLicenseFlags();
        [FreeFunction("InternalEditorUtilityBindings::GetAuthToken")]
        public static string GetAuthToken();
        [FreeFunction("InternalEditorUtilityBindings::OpenEditorConsole")]
        public static void OpenEditorConsole();
        [FreeFunction("InternalEditorUtilityBindings::GetGameObjectInstanceIDFromComponent")]
        public static int GetGameObjectInstanceIDFromComponent(int instanceID);
        [FreeFunction("InternalEditorUtilityBindings::ReadScreenPixel")]
        public static Color[] ReadScreenPixel(Vector2 pixelPos, int sizex, int sizey);
        [FreeFunction("InternalEditorUtilityBindings::ReadScreenPixelUnderCursor")]
        public static Color[] ReadScreenPixelUnderCursor(Vector2 cursorPosHint, int sizex, int sizey);
        [NativeMethod("SetDevice")]
        [StaticAccessor("GetGpuDeviceManager()", StaticAccessorType.Dot)]
        public static void SetGpuDeviceAndRecreateGraphics(int index, string name);
        [NativeMethod("IsSupported")]
        [StaticAccessor("GetGpuDeviceManager()", StaticAccessorType.Dot)]
        public static bool IsGpuDeviceSelectionSupported();
        [FreeFunction("InternalEditorUtilityBindings::GetGpuDevices")]
        public static string[] GetGpuDevices();
        [FreeFunction("InternalEditorUtilityBindings::OpenPlayerConsole")]
        public static void OpenPlayerConsole();
        public static string TextifyEvent(Event evt);
        [FreeFunction]
        public static string[] GetAvailableDiffTools();
        [FreeFunction]
        public static string GetNoDiffToolsDetectedMessage();
        [FreeFunction("InternalEditorUtilityBindings::TransformBounds")]
        public static Bounds TransformBounds(Bounds b, Transform t);
        [NativeMethod("SetCustomLighting")]
        [StaticAccessor("CustomLighting::Get()", StaticAccessorType.Dot)]
        public static void SetCustomLightingInternal([Unmarshalled] Light[] lights, Color ambient);
        public static void SetCustomLighting(Light[] lights, Color ambient);
        [NativeMethod("RestoreSceneLighting")]
        [StaticAccessor("CustomLighting::Get()", StaticAccessorType.Dot)]
        public static void RemoveCustomLighting();
        [StaticAccessor("GetRenderManager()", StaticAccessorType.Dot)]
        public static bool HasFullscreenCamera();
        public static Bounds CalculateSelectionBounds(bool usePivotOnlyForParticles, bool onlyUseActiveSelection);
        [FreeFunction]
        public static Bounds CalculateSelectionBounds(bool usePivotOnlyForParticles, bool onlyUseActiveSelection, bool ignoreEditableField);
        [FreeFunction("SetPlayerFocus")]
        public static void OnGameViewFocus(bool focus);
        [FreeFunction("OpenScriptFile")]
        public static bool OpenFileAtLineExternal(string filename, int line, int column);
        public static bool OpenFileAtLineExternal(string filename, int line);
        [FreeFunction("AssetDatabaseDeprecated::CanConnectToCacheServer")]
        public static bool CanConnectToCacheServer();
        [FreeFunction]
        public static DllType DetectDotNetDll(string path);
        public static bool IsDotNet4Dll(string path);
        [FreeFunction(IsThreadSafe = True)]
        public static bool CurrentThreadIsMainThread();
        [FreeFunction("InternalEditorUtilityBindings::GetCrashReportFolder")]
        public static string GetCrashReportFolder();
        [FreeFunction("InternalEditorUtilityBindings::GetCrashHandlerProcessID")]
        public static uint GetCrashHandlerProcessID();
        [FreeFunction("InternalEditorUtilityBindings::ResetCursor")]
        public static void ResetCursor();
        [FreeFunction("InternalEditorUtilityBindings::VerifyCacheServerIntegrity")]
        public static ulong VerifyCacheServerIntegrity();
        [FreeFunction("InternalEditorUtilityBindings::FixCacheServerIntegrityErrors")]
        public static ulong FixCacheServerIntegrityErrors();
        [FreeFunction]
        public static int DetermineDepthOrder(Transform lhs, Transform rhs);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The Module Manager is deprecated", True)]
        public static void ShowPackageManagerWindow();
        [FreeFunction("InternalEditorUtilityBindings::PassAndReturnVector2")]
        public static Vector2 PassAndReturnVector2(Vector2 v);
        [FreeFunction("InternalEditorUtilityBindings::PassAndReturnColor32")]
        public static Color32 PassAndReturnColor32(Color32 c);
        [FreeFunction("InternalEditorUtilityBindings::SaveCursorToFile")]
        public static bool SaveCursorToFile(string path, Texture2D image, Vector2 hotSpot);
        public static string CountToString(ulong count);
        [NativeMethod("EnsureUntitledSceneHasBeenSaved")]
        [Obsolete("use EditorSceneManager.EnsureUntitledSceneHasBeenSaved")]
        [StaticAccessor("GetSceneManager()", StaticAccessorType.Dot)]
        public static bool EnsureSceneHasBeenSaved(string operation);
        public static Texture2D FindIconForFile(string fileName);
        public static Texture2D GetIconForFile(string fileName);
        public static string[] GetEditorSettingsList(string prefix, int count);
        public static void SaveEditorSettingsList(string prefix, string[] aList, int count);
        public static string TextAreaForDocBrowser(Rect position, string text, GUIStyle style);
        public static Camera[] GetSceneViewCameras();
        public static void ShowGameView();
        public static List<int> GetNewSelection(int clickedInstanceID, List<int> allInstanceIDs, List<int> selectedInstanceIDs, int lastClickedInstanceID, bool keepMultiSelection, bool useShiftAsActionKey, bool allowMultiSelection);
        public static bool IsValidFileName(string filename);
        public static string RemoveInvalidCharsFromFileName(string filename, bool logIfInvalidChars);
        public static string GetDisplayStringOfInvalidCharsOfFileName(string filename);
        public static void SetShowGizmos(bool value);
    }
}
