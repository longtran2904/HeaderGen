#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace UnityEditor.Graphs
{
    [DefaultMember("Item")]
    public class Node : ScriptableObject
    {
        [SerializeField]
        protected List<Slot> m_Slots;
        [SerializeField]
        protected string m_GenericTypeString;
        [SerializeField]
        public Styles.Color color;
        [SerializeField]
        public string style;
        [SerializeField]
        public Rect position;

        public Node();

        public Slot this[string name] { get; }
        public Slot this[int index] { get; }
        public bool nodeIsInvalid { get; }
        public string nodeInvalidError { get; set; }
        public Graph graph { get; set; }
        public Type genericType { get; set; }
        public bool isGeneric { get; }
        public bool isDragging { get; }
        public virtual string title { get; set; }
        public bool hasTitle { get; }
        public virtual string windowTitle { get; }
        public List<Slot> slots { get; }
        public IEnumerable<Slot> inputSlots { get; }
        public IEnumerable<Slot> outputSlots { get; }
        public IEnumerable<Slot> inputDataSlots { get; }
        public IEnumerable<Slot> outputDataSlots { get; }
        public IEnumerable<Slot> inputFlowSlots { get; }
        public IEnumerable<Slot> outputFlowSlots { get; }
        public List<Property> properties { get; }
        public IEnumerable<Property> settingProperties { get; }
        public IEnumerable<Edge> outputEdges { get; }
        public IEnumerable<Edge> inputEdges { get; }
        public IEnumerable<Edge> outputFlowEdges { get; }
        public IEnumerable<Edge> inputFlowEdges { get; }
        public IEnumerable<Edge> outputDataEdges { get; }
        public IEnumerable<Edge> inputDataEdges { get; }

        public static T Instance<T>() where T : Node, new();
        public static Node Instance();
        public Slot AddInputSlot(string name);
        public Slot AddInputSlot(string name, Type type);
        public Slot AddOutputSlot(string name);
        public Slot AddOutputSlot(string name, Type type);
        public void AddSlot(Slot s);
        public virtual void AddSlot(Slot s, int index);
        public virtual void RemoveSlot(Slot s);
        public virtual void ChangeSlotType(Slot s, Type toType);
        public virtual void RenameProperty(string oldName, string newName, Type newType);
        public virtual void SetGenericPropertyArgumentType(Type type);
        public virtual void ResetGenericPropertyArgumentType();
        public virtual void InputEdgeChanged(Edge e);
        public virtual void AddedToGraph();
        public virtual void RemovingFromGraph();
        public override string ToString();
        public virtual void NodeUI(GraphGUI host);
        public Property ConstructAndAddProperty(Type type, string name);
        public Property ConstructAndAddProperty(string serializedTypeString, string name);
        public Property AddOrModifyProperty(Type dataType, string name);
        public Property AddOrModifyPropertyForSlot(Slot s);
        public void AddProperty(Property p);
        public string GetSettingPropertyTitle(Property property);
        public void RemoveProperty(string name);
        public void RemoveProperty(Property p);
        public void SetPropertyValueOrCreateAndAddProperty(string name, Type type, object value);
        public void SetPropertyValue(string name, object value);
        public object GetPropertyValue(string name);
        public object GetSlotValue(string slotName);
        public object TryGetSlotPropertyValue(Slot slot);
        public Property GetProperty(string name);
        public Property TryGetProperty(string name);
        public Property GetOrCreateAndAddProperty(Type type, string name);
        public virtual void Dirty();
        public virtual void BeginDrag();
        public virtual void OnDrag();
        public virtual void EndDrag();
    }
}
