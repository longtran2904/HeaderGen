#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityEditor
{
    public class SceneVisibilityManager : ScriptableSingleton<SceneVisibilityManager>
    {
        public SceneVisibilityManager();

        public static event Action visibilityChanged;
        public static event Action pickingChanged;

        public void HideAll();
        public void DisableAllPicking();
        public void Show(GameObject gameObject, bool includeDescendants);
        public void Hide(GameObject gameObject, bool includeDescendants);
        public void DisablePicking(GameObject gameObject, bool includeDescendants);
        public void EnablePicking(GameObject gameObject, bool includeDescendants);
        public void ShowAll();
        public void EnableAllPicking();
        public void Show(Scene scene);
        public void EnablePicking(Scene scene);
        public void Hide(Scene scene);
        public void DisablePicking(Scene scene);
        public bool IsHidden(GameObject gameObject, bool includeDescendants = False);
        public bool IsHidden(Scene scene);
        public bool IsPickingDisabled(GameObject gameObject, bool includeDescendants = False);
        public bool IsPickingDisabled(Scene scene);
        public bool AreAllDescendantsHidden(Scene scene);
        public bool IsPickingDisabledOnAllDescendants(Scene scene);
        public bool AreAnyDescendantsHidden(Scene scene);
        public bool IsPickingDisabledOnAnyDescendant(Scene scene);
        public void Show(GameObject[] gameObjects, bool includeDescendants);
        public void Hide(GameObject[] gameObjects, bool includeDescendants);
        public void DisablePicking(GameObject[] gameObjects, bool includeDescendants);
        public void EnablePicking(GameObject[] gameObjects, bool includeDescendants);
        public void Isolate(GameObject gameObject, bool includeDescendants);
        public void Isolate(GameObject[] gameObjects, bool includeDescendants);
        public void ToggleVisibility(GameObject gameObject, bool includeDescendants);
        public void TogglePicking(GameObject gameObject, bool includeDescendants);
        public bool AreAllDescendantsHidden(GameObject gameObject);
        public bool AreAllDescendantsVisible(GameObject gameObject);
        public bool IsPickingDisabledOnAllDescendants(GameObject gameObject);
        public bool IsPickingEnabledOnAllDescendants(GameObject gameObject);
        public bool IsCurrentStageIsolated();
        public void ExitIsolation();
    }
}
