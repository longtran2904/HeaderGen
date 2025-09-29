#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class Pill : VisualElement
    {

        public Pill();
        public Pill(VisualElement left, VisualElement right);

        public bool highlighted { get; set; }
        public string text { get; set; }
        public Texture icon { get; set; }
        public VisualElement left { get; set; }
        public VisualElement right { get; set; }
        public class UxmlFactory : UxmlFactory<Pill, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : VisualElement.UxmlTraits
        {

            public UxmlTraits();

            public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription { get; }

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
