#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Toggle Group", 31)]
    [DisallowMultipleComponent]
    public class ToggleGroup : UIBehaviour
    {

        protected List<Toggle> m_Toggles;

        protected ToggleGroup();

        public bool allowSwitchOff { get; set; }

        protected override void Start();
        protected override void OnEnable();
        public void NotifyToggleOn(Toggle toggle, bool sendCallback = True);
        public void UnregisterToggle(Toggle toggle);
        public void RegisterToggle(Toggle toggle);
        public void EnsureValidState();
        public bool AnyTogglesOn();
        public IEnumerable<Toggle> ActiveToggles();
        public Toggle GetFirstActiveToggle();
        public void SetAllTogglesOff(bool sendCallback = True);
    }
}
