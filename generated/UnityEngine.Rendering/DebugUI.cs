#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;

namespace UnityEngine.Rendering
{
    public class DebugUI
    {
        public DebugUI();

        public class Container : Widget, IContainer
        {
            public Container();
            public Container(string displayName, ObservableList<Widget> children);

            public ObservableList<Widget> children { get; }
            public override Panel panel { get; }

            protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e);
            protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e);
            public override int GetHashCode();
        }
        public class Foldout : Container, IValueField
        {
            public bool opened;
            public bool isHeader;
            public List<ContextMenuItem> contextMenuItems;

            public Foldout();
            public Foldout(string displayName, ObservableList<Widget> children, string[] columnLabels = null, string[] columnTooltips = null);

            public bool isReadOnly { get; }
            public string[] columnLabels { get; set; }
            public string[] columnTooltips { get; set; }

            public bool GetValue();
            public void SetValue(object value);
            public object ValidateValue(object value);
            public void SetValue(bool value);

            public struct ContextMenuItem
            {
                public string displayName;
                public Action action;
            }
        }
        public class HBox : Container
        {
            public HBox();
        }
        public class VBox : Container
        {
            public VBox();
        }
        public class Table : Container
        {
            public bool isReadOnly;
            public Vector2 scroll;

            public Table();

            public MultiColumnHeader Header { get; }

            public void SetColumnVisibility(int index, bool visible);
            public bool GetColumnVisibility(int index);
            protected override void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e);
            protected override void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e);

            public class Row : Foldout
            {
                public Row();
            }
        }
        [Flags]
        public enum Flags
        {
            None = 0,
            EditorOnly = 2,
            RuntimeOnly = 4,
            EditorForceUpdate = 8
        }
        public abstract class Widget
        {
            protected Panel m_Panel;
            protected IContainer m_Parent;
            public Func<bool> isHiddenCallback;

            protected Widget();

            public virtual Panel panel { get; }
            public virtual IContainer parent { get; }
            public Flags flags { get; set; }
            public string displayName { get; set; }
            public string tooltip { get; set; }
            public string queryPath { get; }
            public bool isEditorOnly { get; }
            public bool isRuntimeOnly { get; }
            public bool isInactiveInEditor { get; }
            public bool isHidden { get; }
            public NameAndTooltip nameAndTooltip { set; }

            public override int GetHashCode();

            public struct NameAndTooltip
            {
                public string name;
                public string tooltip;
            }
        }
        public interface IContainer
        {
            ObservableList<Widget> children { get; }
            string displayName { get; set; }
            string queryPath { get; }
        }
        public interface IValueField
        {
            object GetValue();
            void SetValue(object value);
            object ValidateValue(object value);
        }
        public class Button : Widget
        {
            public Button();

            public Action action { get; set; }
        }
        public class Value : Widget
        {
            public float refreshRate;

            public Value();

            public Func<object> getter { get; set; }

            public object GetValue();
        }
        public abstract class Field<T> : Widget, IValueField
        {
            public Action<Field<T>, T> onValueChanged;

            protected Field();

            public Func<T> getter { get; set; }
            public Action<T> setter { get; set; }

            public virtual T ValidateValue(T value);
            public T GetValue();
            public void SetValue(object value);
            public void SetValue(T value);
        }
        public class BoolField : Field<bool>
        {
            public BoolField();
        }
        public class HistoryBoolField : BoolField
        {
            public HistoryBoolField();

            public Func<bool>[] historyGetter { get; set; }
            public int historyDepth { get; }

            public bool GetHistoryValue(int historyIndex);
        }
        public class IntField : Field<int>
        {
            public Func<int> min;
            public Func<int> max;
            public int incStep;
            public int intStepMult;

            public IntField();

            public override int ValidateValue(int value);
        }
        public class UIntField : Field<uint>
        {
            public Func<uint> min;
            public Func<uint> max;
            public uint incStep;
            public uint intStepMult;

            public UIntField();

            public override uint ValidateValue(uint value);
        }
        public class FloatField : Field<float>
        {
            public Func<float> min;
            public Func<float> max;
            public float incStep;
            public float incStepMult;
            public int decimals;

            public FloatField();

            public override float ValidateValue(float value);
        }
        public class EnumField : Field<int>
        {
            public GUIContent[] enumNames;
            public int[] enumValues;

            public EnumField();

            public Func<int> getIndex { get; set; }
            public Action<int> setIndex { get; set; }
            public int currentIndex { get; set; }
            public Type autoEnum { set; }
        }
        public class HistoryEnumField : EnumField
        {
            public HistoryEnumField();

            public Func<int>[] historyIndexGetter { get; set; }
            public int historyDepth { get; }

            public int GetHistoryValue(int historyIndex);
        }
        public class BitField : Field<Enum>
        {
            public BitField();

            public GUIContent[] enumNames { get; }
            public int[] enumValues { get; }
            public Type enumType { get; set; }
        }
        public class ColorField : Field<Color>
        {
            public bool hdr;
            public bool showAlpha;
            public bool showPicker;
            public float incStep;
            public float incStepMult;
            public int decimals;

            public ColorField();

            public override Color ValidateValue(Color value);
        }
        public class Vector2Field : Field<Vector2>
        {
            public float incStep;
            public float incStepMult;
            public int decimals;

            public Vector2Field();
        }
        public class Vector3Field : Field<Vector3>
        {
            public float incStep;
            public float incStepMult;
            public int decimals;

            public Vector3Field();
        }
        public class Vector4Field : Field<Vector4>
        {
            public float incStep;
            public float incStepMult;
            public int decimals;

            public Vector4Field();
        }
        public class MessageBox : Widget
        {
            public Style style;

            public MessageBox();

            public enum Style
            {
                Info = 0,
                Warning = 1,
                Error = 2
            }
        }
        public class Panel : IComparable<Panel>, IContainer
        {
            public Panel();

            public Flags flags { get; set; }
            public string displayName { get; set; }
            public int groupIndex { get; set; }
            public string queryPath { get; }
            public bool isEditorOnly { get; }
            public bool isRuntimeOnly { get; }
            public bool isInactiveInEditor { get; }
            public bool editorForceUpdate { get; }
            public ObservableList<Widget> children { get; }

            public event Action<Panel> onSetDirty;

            protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e);
            protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e);
            public void SetDirty();
            public override int GetHashCode();
        }
    }
}
