#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using System.Collections.ObjectModel;

namespace UnityEngine.Rendering
{
    public sealed class DebugManager
    {

        public bool refreshEditorRequested;

        public static DebugManager instance { get; }
        public ReadOnlyCollection<DebugUI.Panel> panels { get; }
        public bool displayEditorUI { get; }
        public bool enableRuntimeUI { get; set; }
        public bool displayRuntimeUI { get; set; }
        public bool displayPersistentRuntimeUI { get; set; }

        public event Action<bool> onDisplayRuntimeUIChanged;
        public event Action onSetDirty;

        public void ToggleEditorUI(bool open);
        public void RefreshEditor();
        public void Reset();
        public void ReDrawOnScreenDebug();
        public void RegisterData(IDebugData data);
        public void UnregisterData(IDebugData data);
        public int GetState();
        public void RequestEditorWindowPanelIndex(int index);
        public DebugUI.Panel GetPanel(string displayName, bool createIfNull = False, int groupIndex = 0, bool overrideIfExist = False);
        public void RemovePanel(string displayName);
        public void RemovePanel(DebugUI.Panel panel);
        public DebugUI.Widget GetItem(string queryPath);
    }
}
