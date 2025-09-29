#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/IMGUI/Event.bindings.h")]
    [StaticAccessor("GUIEvent", StaticAccessorType.DoubleColon)]
    public sealed class Event
    {

        public Event();
        public Event(int displayIndex);
        public Event(Event other);

        ~Event();

        [NativeProperty("type", False, TargetType.Field)]
        public EventType rawType { get; }
        [NativeProperty("mousePosition", False, TargetType.Field)]
        public Vector2 mousePosition { get; set; }
        [NativeProperty("delta", False, TargetType.Field)]
        public Vector2 delta { get; set; }
        [NativeProperty("pointerType", False, TargetType.Field)]
        public PointerType pointerType { get; set; }
        [NativeProperty("button", False, TargetType.Field)]
        public int button { get; set; }
        [NativeProperty("modifiers", False, TargetType.Field)]
        public EventModifiers modifiers { get; set; }
        [NativeProperty("pressure", False, TargetType.Field)]
        public float pressure { get; set; }
        [NativeProperty("clickCount", False, TargetType.Field)]
        public int clickCount { get; set; }
        [NativeProperty("character", False, TargetType.Field)]
        public char character { get; set; }
        [NativeProperty("keycode", False, TargetType.Field)]
        public KeyCode keyCode { get; set; }
        [NativeProperty("displayIndex", False, TargetType.Field)]
        public int displayIndex { get; set; }
        public EventType type { get; set; }
        public string commandName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);", True)]
        public Ray mouseRay { get; set; }
        public bool shift { get; set; }
        public bool control { get; set; }
        public bool alt { get; set; }
        public bool command { get; set; }
        public bool capsLock { get; set; }
        public bool numeric { get; set; }
        public bool functionKey { get; }
        public static Event current { get; set; }
        public bool isKey { get; }
        public bool isMouse { get; }
        public bool isScrollWheel { get; }

        [FreeFunction("GUIEvent::GetTypeForControl", HasExplicitThis = True)]
        public EventType GetTypeForControl(int controlID);
        public static bool PopEvent([NotNull("ArgumentNullException")] Event outEvent);
        public static int GetEventCount();
        public static Event KeyboardEvent(string key);
        public override int GetHashCode();
        public override bool Equals(object obj);
        public override string ToString();
        public void Use();
    }
}
