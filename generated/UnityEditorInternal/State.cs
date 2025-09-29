#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditorInternal
{
    [NativeClass(null)]
    [Obsolete("State is obsolete. Use UnityEditor.Animations.AnimatorState instead (UnityUpgradable) -> UnityEditor.Animations.AnimatorState", True)]
    public class State : UnityEngine.Object
    {
        public State();

        public string uniqueName { get; }
        public int uniqueNameHash { get; }
        public float speed { get; set; }
        public bool mirror { get; set; }
        public bool iKOnFeet { get; set; }
        public string tag { get; set; }

        public Motion GetMotion();
        public Motion GetMotion(AnimatorControllerLayer layer);
        public BlendTree CreateBlendTree();
        public BlendTree CreateBlendTree(AnimatorControllerLayer layer);
    }
}
