#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor
{
    public class AssetSettingsProvider : SettingsProvider
    {

        public AssetSettingsProvider(string settingsWindowPath, Func<Editor> editorCreator, IEnumerable<string> keywords = null);
        public AssetSettingsProvider(string settingsWindowPath, Func<UnityEngine.Object> settingsGetter);

        public Editor settingsEditor { get; }

        public static AssetSettingsProvider CreateProviderFromAssetPath(string settingsWindowPath, string assetPath, IEnumerable<string> keywords = null);
        public static AssetSettingsProvider CreateProviderFromObject(string settingsWindowPath, UnityEngine.Object settingsObj, IEnumerable<string> keywords = null);
        public static AssetSettingsProvider CreateProviderFromResourcePath(string settingsWindowPath, string resourcePath, IEnumerable<string> keywords = null);
        public override void OnActivate(string searchContext, VisualElement rootElement);
        public override void OnDeactivate();
        public override void OnGUI(string searchContext);
        public override void OnTitleBarGUI();
        public override void OnFooterBarGUI();
    }
}
