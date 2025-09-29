#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine.Experimental.Rendering
{
    public sealed class RayTracingAccelerationStructure : IDisposable
    {

        public RayTracingAccelerationStructure(RASSettings settings);
        public RayTracingAccelerationStructure();

        ~RayTracingAccelerationStructure();

        public void Dispose();
        public void Release();
        public void Build();
        [Obsolete("Method Update has been deprecated. Use Build instead (UnityUpgradable) -> Build()", True)]
        public void Update();
        [FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::Build", HasExplicitThis = True)]
        public void Build(Vector3 relativeOrigin);
        [FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::Update", HasExplicitThis = True)]
        [Obsolete("Method Update has been deprecated. Use Build instead (UnityUpgradable) -> Build(*)", True)]
        public void Update(Vector3 relativeOrigin);
        [FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::AddInstanceDeprecated", HasExplicitThis = True)]
        public void AddInstance([NotNull("ArgumentNullException")] Renderer targetRenderer, bool[] subMeshMask = null, bool[] subMeshTransparencyFlags = null, bool enableTriangleCulling = True, bool frontTriangleCounterClockwise = False, uint mask = 255, uint id = 4294967295);
        public void AddInstance(Renderer targetRenderer, RayTracingSubMeshFlags[] subMeshFlags, bool enableTriangleCulling = True, bool frontTriangleCounterClockwise = False, uint mask = 255, uint id = 4294967295);
        [FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::RemoveInstance", HasExplicitThis = True)]
        public void RemoveInstance([NotNull("ArgumentNullException")] Renderer targetRenderer);
        public void AddInstance(GraphicsBuffer aabbBuffer, uint numElements, Material material, bool isCutOff, bool enableTriangleCulling = True, bool frontTriangleCounterClockwise = False, uint mask = 255, bool reuseBounds = False, uint id = 4294967295);
        public void AddInstance(GraphicsBuffer aabbBuffer, uint numElements, Material material, Matrix4x4 instanceTransform, bool isCutOff, bool enableTriangleCulling = True, bool frontTriangleCounterClockwise = False, uint mask = 255, bool reuseBounds = False, uint id = 4294967295);
        [FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::UpdateInstanceTransform", HasExplicitThis = True)]
        public void UpdateInstanceTransform([NotNull("ArgumentNullException")] Renderer renderer);
        [FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::UpdateInstanceMask", HasExplicitThis = True)]
        public void UpdateInstanceMask([NotNull("ArgumentNullException")] Renderer renderer, uint mask);
        [FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::UpdateInstanceID", HasExplicitThis = True)]
        public void UpdateInstanceID([NotNull("ArgumentNullException")] Renderer renderer, uint instanceID);
        [FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::GetSize", HasExplicitThis = True)]
        public ulong GetSize();
        [FreeFunction(Name = "RayTracingAccelerationStructure_Bindings::GetInstanceCount", HasExplicitThis = True)]
        public uint GetInstanceCount();
        [Flags]
        public enum RayTracingModeMask
        {

            Nothing = 0,
            Static = 2,
            DynamicTransform = 4,
            DynamicGeometry = 8,
            Everything = 14
        }
        public enum ManagementMode
        {

            Manual = 0,
            Automatic = 1
        }
        public struct RASSettings
        {

            public ManagementMode managementMode;
            public RayTracingModeMask rayTracingModeMask;
            public int layerMask;

            public RASSettings(ManagementMode sceneManagementMode, RayTracingModeMask rayTracingModeMask, int layerMask);
        }
    }
}
