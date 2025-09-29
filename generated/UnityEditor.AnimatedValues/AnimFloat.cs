#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Events;

namespace UnityEditor.AnimatedValues
{
    public class AnimFloat : BaseAnimValueNonAlloc<float>
    {

        public AnimFloat(float value);
        public AnimFloat(float value, UnityAction callback);

        protected override float GetValue();
    }
}
