#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Events;

namespace UnityEditor.AnimatedValues
{
    public class AnimBool : BaseAnimValueNonAlloc<bool>
    {
        public AnimBool();
        public AnimBool(bool value);
        public AnimBool(UnityAction callback);
        public AnimBool(bool value, UnityAction callback);

        public float faded { get; }

        protected override bool GetValue();
        public float Fade(float from, float to);
    }
}
