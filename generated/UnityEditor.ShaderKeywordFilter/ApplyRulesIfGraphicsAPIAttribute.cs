#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Rendering;

namespace UnityEditor.ShaderKeywordFilter
{
    public class ApplyRulesIfGraphicsAPIAttribute : GraphicsAPIConstraintAttribute
    {

        public ApplyRulesIfGraphicsAPIAttribute(params GraphicsDeviceType[] graphicsDeviceTypes);
    }
}
