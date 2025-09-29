#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.AssetImporters
{
    [NativeHeader("Editor/Src/AssetPipeline/ModelImporting/CameraDescription.h")]
    [RequiredByNativeCode]
    public class CameraDescription : IDisposable
    {

        public CameraDescription();

        ~CameraDescription();

        public void Dispose();
        public bool TryGetProperty(string propertyName, out float value);
        public bool TryGetProperty(string propertyName, out Vector4 value);
        public bool TryGetProperty(string propertyName, out string value);
        public bool TryGetProperty(string propertyName, out int value);
        public void GetVector4PropertyNames(List<string> names);
        public void GetFloatPropertyNames(List<string> names);
        public void GetStringPropertyNames(List<string> names);
        public void GetIntPropertyNames(List<string> names);
        public bool TryGetAnimationCurve(string clipName, string propertyName, out AnimationCurve value);
        public bool HasAnimationCurveInClip(string clipName, string propertyName);
        public bool HasAnimationCurve(string propertyName);
    }
}
