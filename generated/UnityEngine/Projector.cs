#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Camera/Projector.h")]
    public sealed class Projector : Behaviour
    {
        public Projector();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property isOrthoGraphic has been deprecated. Use orthographic instead (UnityUpgradable) -> orthographic", True)]
        public bool isOrthoGraphic { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property orthoGraphicSize has been deprecated. Use orthographicSize instead (UnityUpgradable) -> orthographicSize", True)]
        public float orthoGraphicSize { get; set; }
        public float nearClipPlane { get; set; }
        public float farClipPlane { get; set; }
        public float fieldOfView { get; set; }
        public float aspectRatio { get; set; }
        public bool orthographic { get; set; }
        public float orthographicSize { get; set; }
        public int ignoreLayers { get; set; }
        public Material material { get; set; }
    }
}
