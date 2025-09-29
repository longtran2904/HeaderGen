#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Rendering;

namespace UnityEditor.ShaderKeywordFilter
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field, AllowMultiple = False)]
    public class GraphicsAPIConstraintAttribute : Attribute
    {
        public GraphicsAPIConstraintAttribute(bool negate, params GraphicsDeviceType[] graphicsDeviceTypes);
    }
}
