#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeClass("ContactFilter", "struct ContactFilter;")]
    [NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
    [RequiredByNativeCode(Optional = True, GenerateProxy = True)]
    public struct ContactFilter2D
    {

        [NativeName("m_UseTriggers")]
        public bool useTriggers;
        [NativeName("m_UseLayerMask")]
        public bool useLayerMask;
        [NativeName("m_UseDepth")]
        public bool useDepth;
        [NativeName("m_UseOutsideDepth")]
        public bool useOutsideDepth;
        [NativeName("m_UseNormalAngle")]
        public bool useNormalAngle;
        [NativeName("m_UseOutsideNormalAngle")]
        public bool useOutsideNormalAngle;
        [NativeName("m_LayerMask")]
        public LayerMask layerMask;
        [NativeName("m_MinDepth")]
        public float minDepth;
        [NativeName("m_MaxDepth")]
        public float maxDepth;
        [NativeName("m_MinNormalAngle")]
        public float minNormalAngle;
        [NativeName("m_MaxNormalAngle")]
        public float maxNormalAngle;
        public const float NormalAngleUpperLimit = 359.9999F;

        public bool isFiltering { get; }

        public ContactFilter2D NoFilter();
        public void ClearLayerMask();
        public void SetLayerMask(LayerMask layerMask);
        public void ClearDepth();
        public void SetDepth(float minDepth, float maxDepth);
        public void ClearNormalAngle();
        public void SetNormalAngle(float minNormalAngle, float maxNormalAngle);
        public bool IsFilteringTrigger([Writable] Collider2D collider);
        public bool IsFilteringLayerMask(GameObject obj);
        public bool IsFilteringDepth(GameObject obj);
        public bool IsFilteringNormalAngle(Vector2 normal);
        public bool IsFilteringNormalAngle(float angle);
    }
}
