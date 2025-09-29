#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Events;

namespace UnityEditor.AnimatedValues
{
    public class AnimQuaternion : BaseAnimValueNonAlloc<Quaternion>
    {

        public AnimQuaternion(Quaternion value);
        public AnimQuaternion(Quaternion value, UnityAction callback);

        protected override Quaternion GetValue();
    }
}
