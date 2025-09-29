#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.UIElements;

namespace UnityEditor
{
    public class SettingsProvider
    {

        public SettingsProvider(string path, SettingsScope scopes, IEnumerable<string> keywords = null);

        public string label { get; set; }
        public string settingsPath { get; }
        public SettingsScope scope { get; }
        public IEnumerable<string> keywords { get; set; }
        public Action<string> guiHandler { get; set; }
        public Action titleBarGuiHandler { get; set; }
        public Action footerBarGuiHandler { get; set; }
        public Action<string, VisualElement> activateHandler { get; set; }
        public Action deactivateHandler { get; set; }
        public Func<string, bool> hasSearchInterestHandler { get; set; }
        public Action inspectorUpdateHandler { get; set; }

        public virtual void OnActivate(string searchContext, VisualElement rootElement);
        public virtual void OnDeactivate();
        public virtual bool HasSearchInterest(string searchContext);
        public virtual void OnGUI(string searchContext);
        public virtual void OnTitleBarGUI();
        public virtual void OnFooterBarGUI();
        public virtual void OnInspectorUpdate();
        public void Repaint();
        public void PopulateSearchKeywordsFromGUIContentProperties<T>();
        public static IEnumerable<string> GetSearchKeywordsFromGUIContentProperties<T>();
        public static IEnumerable<string> GetSearchKeywordsFromSerializedObject(SerializedObject serializedObject);
        public static IEnumerable<string> GetSearchKeywordsFromPath(string path);
    }
}
