#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Animations
{
    [NativeType("Editor/Src/Animation/BlendTree.h")]
    public struct ChildMotion
    {
        public Motion motion { get; set; }
        public float threshold { get; set; }
        public Vector2 position { get; set; }
        public float timeScale { get; set; }
        public float cycleOffset { get; set; }
        public string directBlendParameter { get; set; }
        public bool mirror { get; set; }
    }
}
