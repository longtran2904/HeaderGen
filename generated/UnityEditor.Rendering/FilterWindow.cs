#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Rendering
{
    [InitializeOnLoad]
    public class FilterWindow : EditorWindow
    {
        public static readonly float DefaultWidth;
        public static readonly float DefaultHeight;

        public FilterWindow();

        public interface IProvider
        {
            Vector2 position { get; set; }

            void CreateComponentTree(List<Element> tree);
            bool GoToChild(Element element, bool addIfComponent);
        }
        public class Element : IComparable
        {
            public int level;
            public GUIContent content;

            public Element();

            public string name { get; }

            public int CompareTo(object o);
        }
        public class GroupElement : Element
        {
            public Vector2 scroll;
            public int selectedIndex;

            public GroupElement(int level, string name);

            public bool WantsFocus { get; protected set; }
            public virtual bool ShouldDisable { get; }

            public virtual bool HandleKeyboard(Event evt, FilterWindow window, Action goToParent);
            public virtual bool OnGUI(FilterWindow sFilterWindow);
        }
    }
}
