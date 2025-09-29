#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Animations
{
    [ExcludeFromPreset]
    [NativeHeader("Editor/Src/Animation/BlendTree.bindings.h")]
    [NativeType("Editor/Src/Animation/BlendTree.h")]
    public class BlendTree : Motion
    {
        public BlendTree();

        public string blendParameter { get; set; }
        public string blendParameterY { get; set; }
        public BlendTreeType blendType { get; set; }
        public ChildMotion[] children { get; set; }
        public bool useAutomaticThresholds { get; set; }
        public float minThreshold { get; set; }
        public float maxThreshold { get; set; }

        public void AddChild(Motion motion);
        public void AddChild(Motion motion, Vector2 position);
        public void AddChild(Motion motion, float threshold);
        public void RemoveChild(int index);
        public BlendTree CreateBlendTreeChild(float threshold);
        public BlendTree CreateBlendTreeChild(Vector2 position);
    }
}
