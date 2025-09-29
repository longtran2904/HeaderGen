#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System;
using System.Reflection;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine.UIElements;

namespace UnityEditor.ShaderGraph.Drawing.Inspector.PropertyDrawers
{
    [SGPropertyDrawer(typeof(GraphData))]
    public class GraphDataPropertyDrawer : IPropertyDrawer
    {
        public GraphDataPropertyDrawer();

        public Action inspectorUpdateDelegate { get; set; }

        public void GetPropertyData(PostTargetSettingsChangedCallback postChangeValueCallback, ChangeGraphDefaultPrecisionCallback changeGraphDefaultPrecisionCallback);
        public VisualElement DrawProperty(PropertyInfo propertyInfo, object actualObject, InspectableAttribute attribute);

        public delegate void ChangeGraphDefaultPrecisionCallback(GraphPrecision newDefaultGraphPrecision);
        public delegate void PostTargetSettingsChangedCallback();
    }
}
