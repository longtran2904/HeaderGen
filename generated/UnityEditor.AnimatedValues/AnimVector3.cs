#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Events;

namespace UnityEditor.AnimatedValues
{
    public class AnimVector3 : BaseAnimValueNonAlloc<Vector3>
    {

        public AnimVector3();
        public AnimVector3(Vector3 value);
        public AnimVector3(Vector3 value, UnityAction callback);

        protected override Vector3 GetValue();
    }
}
