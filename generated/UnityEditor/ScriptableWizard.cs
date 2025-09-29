#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Internal;

namespace UnityEditor
{
    public class ScriptableWizard : EditorWindow
    {
        public ScriptableWizard();

        public string helpString { get; set; }
        public string errorString { get; set; }
        public string createButtonName { get; set; }
        public string otherButtonName { get; set; }
        public bool isValid { get; set; }

        protected virtual bool DrawWizardGUI();
        public static T DisplayWizard<T>(string title) where T : ScriptableWizard;
        public static T DisplayWizard<T>(string title, string createButtonName) where T : ScriptableWizard;
        public static T DisplayWizard<T>(string title, string createButtonName, string otherButtonName) where T : ScriptableWizard;
        [ExcludeFromDocs]
        public static ScriptableWizard DisplayWizard(string title, Type klass, string createButtonName);
        [ExcludeFromDocs]
        public static ScriptableWizard DisplayWizard(string title, Type klass);
        public static ScriptableWizard DisplayWizard(string title, Type klass, [DefaultValue("\"Create\"")] string createButtonName, [DefaultValue("\"\"")] string otherButtonName);
    }
}
