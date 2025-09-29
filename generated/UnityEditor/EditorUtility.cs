#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [NativeHeader("Editor/Mono/EditorUtility.bindings.h")]
    [NativeHeader("Runtime/Shaders/ShaderImpl/ShaderUtilities.h")]
    [NativeHeader("Editor/Mono/MonoEditorUtility.h")]
    public class EditorUtility
    {

        public EditorUtility();

        public static bool audioMasterMute { get; set; }
        public static bool scriptCompilationFailed { get; }

        public static string OpenFilePanel(string title, string directory, string extension);
        public static string OpenFilePanelWithFilters(string title, string directory, string[] filters);
        [FreeFunction("RevealInFinder")]
        public static void RevealInFinder(string path);
        public static bool DisplayDialog(string title, string message, string ok, [DefaultValue("\"\"")] string cancel);
        [ExcludeFromDocs]
        public static bool DisplayDialog(string title, string message, string ok);
        public static int DisplayDialogComplex(string title, string message, string ok, string cancel, string alt);
        [FreeFunction("RunOpenFolderPanel")]
        public static string OpenFolderPanel(string title, string folder, string defaultName);
        [FreeFunction("RunSaveFolderPanel")]
        public static string SaveFolderPanel(string title, string folder, string defaultName);
        [FreeFunction("WarnPrefab")]
        public static bool WarnPrefab(UnityEngine.Object target, string title, string warning, string okButton);
        public static bool IsPersistent(UnityEngine.Object target);
        public static string SaveFilePanel(string title, string directory, string defaultName, string extension);
        public static int NaturalCompare(string a, string b);
        public static UnityEngine.Object InstanceIDToObject(int instanceID);
        public static void CompressTexture([NotNull("ArgumentNullException")] Texture2D texture, TextureFormat format, int quality);
        public static void CompressCubemapTexture([NotNull("ArgumentNullException")] Cubemap texture, TextureFormat format, int quality);
        [FreeFunction("EditorUtility::SetDirtyObjectOrScene")]
        public static void SetDirty([NotNull("ArgumentNullException")] UnityEngine.Object target);
        public static void ClearDirty([NotNull("ArgumentNullException")] UnityEngine.Object target);
        [FreeFunction("InvokeDiffTool")]
        public static string InvokeDiffTool(string leftTitle, string leftFile, string rightTitle, string rightFile, string ancestorTitle, string ancestorFile);
        [FreeFunction("CopySerialized")]
        public static void CopySerialized([NotNull("NullExceptionObject")] UnityEngine.Object source, [NotNull("NullExceptionObject")] UnityEngine.Object dest);
        [FreeFunction("CopyScriptSerialized")]
        public static void CopySerializedManagedFieldsOnly([NotNull("ArgumentNullException")] object source, [NotNull("ArgumentNullException")] object dest);
        [NativeThrows]
        public static UnityEngine.Object[] CollectDependencies([Unmarshalled] UnityEngine.Object[] roots);
        public static UnityEngine.Object[] CollectDeepHierarchy([Unmarshalled] UnityEngine.Object[] roots);
        [Obsolete("Use EditorUtility.UnloadUnusedAssetsImmediate instead", False)]
        public static void UnloadUnusedAssets();
        [Obsolete("Use EditorUtility.UnloadUnusedAssetsImmediate instead", False)]
        public static void UnloadUnusedAssetsIgnoreManagedReferences();
        [FreeFunction("FormatBytes")]
        public static string FormatBytes(long bytes);
        [FreeFunction("DisplayProgressbarLegacy")]
        public static void DisplayProgressBar(string title, string info, float progress);
        public static bool DisplayCancelableProgressBar(string title, string info, float progress);
        [FreeFunction("ClearProgressbarLegacy")]
        public static void ClearProgressBar();
        [FreeFunction("GetObjectEnabled")]
        public static int GetObjectEnabled(UnityEngine.Object target);
        [FreeFunction("SetObjectEnabled")]
        public static void SetObjectEnabled(UnityEngine.Object target, bool enabled);
        public static void SetSelectedRenderState(Renderer renderer, EditorSelectedRenderState renderState);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("ExtractOggFile has no effect anymore", False)]
        public static bool ExtractOggFile(UnityEngine.Object obj, string path);
        [FreeFunction("OpenWithDefaultApp")]
        public static void OpenWithDefaultApp(string fileName);
        public static void SetCameraAnimateMaterials([NotNull("ArgumentNullException")] Camera camera, bool animate);
        public static void SetCameraAnimateMaterialsTime([NotNull("ArgumentNullException")] Camera camera, float time);
        [FreeFunction("ShaderLab::UpdateGlobalShaderProperties")]
        public static void UpdateGlobalShaderProperties(float time);
        [FreeFunction("FindAssetWithKlass", ThrowsException = True)]
        [Obsolete("Use AssetDatabase.LoadAssetAtPath", False)]
        public static UnityEngine.Object FindAsset(string path, Type type);
        [NativeMethod("GetDirtyIndex")]
        public static int GetDirtyCount(int instanceID);
        public static int GetDirtyCount(UnityEngine.Object target);
        public static bool IsDirty(int instanceID);
        public static bool IsDirty(UnityEngine.Object target);
        [RequiredByNativeCode]
        public static void FocusProjectWindow();
        [StaticAccessor("GetApplication()", StaticAccessorType.Dot)]
        public static void RequestScriptReload();
        [FreeFunction("IsRunningUnderCPUEmulation", IsThreadSafe = True)]
        public static bool IsRunningUnderCPUEmulation();
        public static bool LoadWindowLayout(string path);
        public static void CompressTexture(Texture2D texture, TextureFormat format, TextureCompressionQuality quality);
        public static void CompressCubemapTexture(Cubemap texture, TextureFormat format, TextureCompressionQuality quality);
        public static string SaveFilePanelInProject(string title, string defaultName, string extension, string message);
        public static string SaveFilePanelInProject(string title, string defaultName, string extension, string message, string path);
        public static void CopySerializedIfDifferent(UnityEngine.Object source, UnityEngine.Object dest);
        [Obsolete("Use AssetDatabase.GetAssetPath", False)]
        public static string GetAssetPath(UnityEngine.Object asset);
        public static void UnloadUnusedAssetsImmediate();
        public static void UnloadUnusedAssetsImmediate(bool includeMonoReferencesAsRoots);
        [Obsolete("Use BuildPipeline.BuildAssetBundle instead")]
        public static bool BuildResourceFile(UnityEngine.Object[] selection, string pathName);
        public static bool GetDialogOptOutDecision(DialogOptOutDecisionType dialogOptOutDecisionType, string dialogOptOutDecisionStorageKey);
        public static void SetDialogOptOutDecision(DialogOptOutDecisionType dialogOptOutDecisionType, string dialogOptOutDecisionStorageKey, bool optOutDecision);
        public static bool DisplayDialog(string title, string message, string ok, DialogOptOutDecisionType dialogOptOutDecisionType, string dialogOptOutDecisionStorageKey);
        public static bool DisplayDialog(string title, string message, string ok, [DefaultValue("\"\"")] string cancel, DialogOptOutDecisionType dialogOptOutDecisionType, string dialogOptOutDecisionStorageKey);
        public static void DisplayPopupMenu(Rect position, string menuItemPath, MenuCommand command);
        public static void DisplayCustomMenu(Rect position, GUIContent[] options, int selected, SelectMenuItemFunction callback, object userData);
        public static void DisplayCustomMenu(Rect position, GUIContent[] options, int selected, SelectMenuItemFunction callback, object userData, bool showHotkey);
        public static void DisplayCustomMenu(Rect position, GUIContent[] options, Func<int, bool> checkEnabled, int selected, SelectMenuItemFunction callback, object userData, bool showHotkey = False);
        public static string FormatBytes(int bytes);
        [Obsolete("Use EditorUtility.SetSelectedRenderState", False)]
        public static void SetSelectedWireframeHidden(Renderer renderer, bool enabled);
        public static GameObject CreateGameObjectWithHideFlags(string name, HideFlags flags, params Type[] components);
        [Obsolete("Use UnityEditor.Compilation.AssemblyBuilder instead", True)]
        public static string[] CompileCSharp(string[] scripts, string[] references, string[] defines, string outputAssembly);
        [Obsolete("Use PrefabUtility.InstantiatePrefab", False)]
        public static UnityEngine.Object InstantiatePrefab(UnityEngine.Object target);
        [Obsolete("Use PrefabUtility.SaveAsPrefabAsset with a path instead.", False)]
        public static GameObject ReplacePrefab(GameObject go, UnityEngine.Object targetPrefab, ReplacePrefabOptions options);
        [Obsolete("Use PrefabUtility.SaveAsPrefabAsset or PrefabUtility.SaveAsPrefabAssetAndConnect with a path instead.", False)]
        public static GameObject ReplacePrefab(GameObject go, UnityEngine.Object targetPrefab);
        [Obsolete("The concept of creating a completely empty Prefab has been discontinued. You can however use PrefabUtility.SaveAsPrefabAsset with an empty GameObject.", False)]
        public static UnityEngine.Object CreateEmptyPrefab(string path);
        [Obsolete("Use PrefabUtility.RevertPrefabInstance.", False)]
        public static bool ReconnectToLastPrefab(GameObject go);
        [Obsolete("Use PrefabUtility.GetPrefabAssetType and PrefabUtility.GetPrefabInstanceStatus to get the full picture about Prefab types.", False)]
        public static PrefabType GetPrefabType(UnityEngine.Object target);
        [Obsolete("Use PrefabUtility.GetCorrespondingObjectFromSource.", False)]
        public static UnityEngine.Object GetPrefabParent(UnityEngine.Object source);
        [Obsolete("Use PrefabUtility.GetOutermostPrefabInstanceRoot if source is a Prefab instance or source.transform.root.gameObject if source is a Prefab Asset object.", False)]
        public static GameObject FindPrefabRoot(GameObject source);
        [Obsolete("Use PrefabUtility.RevertObjectOverride.", False)]
        public static bool ResetToPrefabState(UnityEngine.Object source);
        public static void DisplayCustomMenuWithSeparators(Rect position, string[] options, bool[] enabled, bool[] separator, int[] selected, SelectMenuItemFunction callback, object userData);
        public static void SetCustomDiffTool(string path, string twoWayDiff, string threeWayDiff, string mergeCommand, bool forceEnableCustomTool = False);
        public static void SetDefaultParentObject(GameObject defaultParentObject);
        public static void ClearDefaultParentObject(Scene scene);
        public static void ClearDefaultParentObject();
        public static void OpenPropertyEditor(UnityEngine.Object obj);
        public delegate void SelectMenuItemFunction(object userData, string[] options, int selected);
    }
}
