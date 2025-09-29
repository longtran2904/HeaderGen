#region UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using System;

namespace UnityEngine
{
    [AttributeUsage(AttributeTargets.Method)]
    public class GUITargetAttribute : Attribute
    {
        public GUITargetAttribute();
        public GUITargetAttribute(int displayIndex);
        public GUITargetAttribute(int displayIndex, int displayIndex1);
        public GUITargetAttribute(int displayIndex, int displayIndex1, params int[] displayIndexList);
    }
}
