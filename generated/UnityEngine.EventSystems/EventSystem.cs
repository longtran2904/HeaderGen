#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
    [AddComponentMenu("Event/Event System")]
    [DisallowMultipleComponent]
    public class EventSystem : UIBehaviour
    {

        protected EventSystem();

        public static EventSystem current { get; set; }
        public bool sendNavigationEvents { get; set; }
        public int pixelDragThreshold { get; set; }
        public BaseInputModule currentInputModule { get; }
        public GameObject firstSelectedGameObject { get; set; }
        public GameObject currentSelectedGameObject { get; }
        [Obsolete("lastSelectedGameObject is no longer supported")]
        public GameObject lastSelectedGameObject { get; }
        public bool isFocused { get; }
        public bool alreadySelecting { get; }

        public void UpdateModules();
        public void SetSelectedGameObject(GameObject selected, BaseEventData pointer);
        public void SetSelectedGameObject(GameObject selected);
        public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults);
        public bool IsPointerOverGameObject();
        public bool IsPointerOverGameObject(int pointerId);
        public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = True, bool createPanelGameObjectsOnStart = True);
        protected override void Start();
        protected override void OnDestroy();
        protected override void OnEnable();
        protected override void OnDisable();
        protected virtual void OnApplicationFocus(bool hasFocus);
        protected virtual void Update();
        public override string ToString();
    }
}
