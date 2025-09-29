#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace TreeEditor
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class TreeAttribute : Attribute
    {
        public string uiLabel;
        public string uiGadget;
        public string uiCurve;
        public string uiRequirement;
        public GUIContent[] uiOptions;
        public float uiCurveMin;
        public float uiCurveMax;
        public float uiMin;
        public float uiMax;

        public TreeAttribute(string uiLabel, string uiGadget, float uiMin, float uiMax);
        public TreeAttribute(string uiLabel, string uiGadget, float uiMin, float uiMax, string uiRequirement);
        public TreeAttribute(string uiLabel, string uiGadget, float uiMin, float uiMax, string uiCurve, float uiCurveMin, float uiCurveMax);
        public TreeAttribute(string uiLabel, string uiGadget, float uiMin, float uiMax, string uiCurve, float uiCurveMin, float uiCurveMax, string uiRequirement);
        public TreeAttribute(string uiLabel, string uiGadget, string uiOptions);
        public TreeAttribute(string uiLabel, string uiGadget, string uiOptions, string uiCurve, float uiCurveMin, float uiCurveMax, string uiRequirement);

        public override string ToString();
    }
}
