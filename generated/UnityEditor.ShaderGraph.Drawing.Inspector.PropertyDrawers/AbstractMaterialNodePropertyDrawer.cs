#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System;
using System.Reflection;
using UnityEngine.UIElements;

namespace UnityEditor.ShaderGraph.Drawing.Inspector.PropertyDrawers
{
    [SGPropertyDrawer(typeof(AbstractMaterialNode))]
    public class AbstractMaterialNodePropertyDrawer : IGetNodePropertyDrawerPropertyData, IPropertyDrawer
    {
        public AbstractMaterialNodePropertyDrawer();

        public Action inspectorUpdateDelegate { get; set; }

        public void GetPropertyData(Action setNodesAsDirtyCallback, Action updateNodeViewsCallback);
        public VisualElement DrawProperty(PropertyInfo propertyInfo, object actualObject, InspectableAttribute attribute);
    }
}
