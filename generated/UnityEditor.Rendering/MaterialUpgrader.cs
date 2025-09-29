#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Rendering
{
    public class MaterialUpgrader
    {
        public MaterialUpgrader();

        public string NewShaderPath { get; }

        public IReadOnlyDictionary<string, string> GetPropertyRenameMap(MaterialPropertyType type);
        public void Upgrade(Material material, UpgradeFlags flags);
        public virtual void Convert(Material srcMaterial, Material dstMaterial);
        public void RenameShader(string oldName, string newName, MaterialFinalizer finalizer = null);
        public void RenameTexture(string oldName, string newName);
        public void RenameFloat(string oldName, string newName);
        public void RenameColor(string oldName, string newName);
        public void RemoveTexture(string name);
        public void SetFloat(string propertyName, float value);
        public void SetColor(string propertyName, Color value);
        public void SetTexture(string propertyName, Texture value);
        public void RenameKeywordToFloat(string oldName, string newName, float setVal, float unsetVal);
        public static bool ProjectFolderContainsNonBuiltinMaterials(List<MaterialUpgrader> upgraders);
        public static void UpgradeProjectFolder(List<MaterialUpgrader> upgraders, string progressBarName, UpgradeFlags flags = UpgradeFlags.None);
        public static void UpgradeProjectFolder(List<MaterialUpgrader> upgraders, HashSet<string> shaderNamesToIgnore, string progressBarName, UpgradeFlags flags = UpgradeFlags.None);
        public static void Upgrade(Material material, MaterialUpgrader upgrader, UpgradeFlags flags);
        public static void Upgrade(Material material, List<MaterialUpgrader> upgraders, UpgradeFlags flags);
        public static bool Upgrade(Material material, List<MaterialUpgrader> upgraders, UpgradeFlags flags, ref string message);
        public static void UpgradeSelection(List<MaterialUpgrader> upgraders, string progressBarName, UpgradeFlags flags = UpgradeFlags.None);
        public static void UpgradeSelection(List<MaterialUpgrader> upgraders, HashSet<string> shaderNamesToIgnore, string progressBarName, UpgradeFlags flags = UpgradeFlags.None);

        public delegate void MaterialFinalizer(Material mat);
        public enum MaterialPropertyType
        {
            Texture = 0,
            Float = 1,
            Color = 2
        }
        [Flags]
        public enum UpgradeFlags
        {
            None = 0,
            LogErrorOnNonExistingProperty = 1,
            CleanupNonUpgradedProperties = 2,
            LogMessageWhenNoUpgraderFound = 4
        }
    }
}
