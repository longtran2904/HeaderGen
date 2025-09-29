#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

namespace UnityEngine
{
    public struct ModifiableContactPair
    {
        public Quaternion rotation;
        public Vector3 position;
        public Quaternion otherRotation;
        public Vector3 otherPosition;

        public int colliderInstanceID { get; }
        public int otherColliderInstanceID { get; }
        public int bodyInstanceID { get; }
        public int otherBodyInstanceID { get; }
        public int contactCount { get; }
        public ModifiableMassProperties massProperties { get; set; }

        public Vector3 GetPoint(int i);
        public void SetPoint(int i, Vector3 v);
        public Vector3 GetNormal(int i);
        public void SetNormal(int i, Vector3 normal);
        public float GetSeparation(int i);
        public void SetSeparation(int i, float separation);
        public Vector3 GetTargetVelocity(int i);
        public void SetTargetVelocity(int i, Vector3 velocity);
        public float GetBounciness(int i);
        public void SetBounciness(int i, float bounciness);
        public float GetStaticFriction(int i);
        public void SetStaticFriction(int i, float staticFriction);
        public float GetDynamicFriction(int i);
        public void SetDynamicFriction(int i, float dynamicFriction);
        public float GetMaxImpulse(int i);
        public void SetMaxImpulse(int i, float value);
        public void IgnoreContact(int i);
        public uint GetFaceIndex(int i);
    }
}
