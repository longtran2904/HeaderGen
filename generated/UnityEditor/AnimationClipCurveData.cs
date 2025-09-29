#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor
{
    public class AnimationClipCurveData
    {

        public string path;
        public Type type;
        public string propertyName;
        public AnimationCurve curve;

        public AnimationClipCurveData();
        public AnimationClipCurveData(EditorCurveBinding binding);
    }
}
