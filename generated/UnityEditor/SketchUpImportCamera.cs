#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType("Modules/SketchUpEditor/SketchUpImporter.h")]
    public struct SketchUpImportCamera
    {
        public Vector3 position;
        public Vector3 lookAt;
        public Vector3 up;
        public float fieldOfView;
        public float aspectRatio;
        public float orthoSize;
        public float nearPlane;
        public float farPlane;
        public bool isPerspective;
    }
}
