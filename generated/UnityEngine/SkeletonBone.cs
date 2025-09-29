#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/HumanDescription.h")]
    [NativeType(CodegenOptions.Custom, "MonoSkeletonBone")]
    [RequiredByNativeCode]
    public struct SkeletonBone
    {
        [NativeName("m_Name")]
        public string name;
        [NativeName("m_Position")]
        public Vector3 position;
        [NativeName("m_Rotation")]
        public Quaternion rotation;
        [NativeName("m_Scale")]
        public Vector3 scale;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("transformModified is no longer used and has been deprecated.", True)]
        public int transformModified { get; set; }
    }
}
