#region UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ParticleSystemModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("ParticleSystemScriptingClasses.h")]
    [NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
    [NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
    [NativeHeader("ParticleSystemScriptingClasses.h")]
    [NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
    [NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
    [NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
    [NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
    [RequireComponent(typeof(Transform))]
    [UsedByNativeCode]
    public sealed class ParticleSystem : Component
    {

        public ParticleSystem();

        [Obsolete("safeCollisionEventSize has been deprecated. Use GetSafeCollisionEventSize() instead (UnityUpgradable) -> ParticlePhysicsExtensions.GetSafeCollisionEventSize(UnityEngine.ParticleSystem)", False)]
        public int safeCollisionEventSize { get; }
        [Obsolete("startDelay property is deprecated. Use main.startDelay or main.startDelayMultiplier instead.", False)]
        public float startDelay { get; set; }
        [Obsolete("loop property is deprecated. Use main.loop instead.", False)]
        public bool loop { get; set; }
        [Obsolete("playOnAwake property is deprecated. Use main.playOnAwake instead.", False)]
        public bool playOnAwake { get; set; }
        [Obsolete("duration property is deprecated. Use main.duration instead.", False)]
        public float duration { get; }
        [Obsolete("playbackSpeed property is deprecated. Use main.simulationSpeed instead.", False)]
        public float playbackSpeed { get; set; }
        [Obsolete("enableEmission property is deprecated. Use emission.enabled instead.", False)]
        public bool enableEmission { get; set; }
        [Obsolete("emissionRate property is deprecated. Use emission.rateOverTime, emission.rateOverDistance, emission.rateOverTimeMultiplier or emission.rateOverDistanceMultiplier instead.", False)]
        public float emissionRate { get; set; }
        [Obsolete("startSpeed property is deprecated. Use main.startSpeed or main.startSpeedMultiplier instead.", False)]
        public float startSpeed { get; set; }
        [Obsolete("startSize property is deprecated. Use main.startSize or main.startSizeMultiplier instead.", False)]
        public float startSize { get; set; }
        [Obsolete("startColor property is deprecated. Use main.startColor instead.", False)]
        public Color startColor { get; set; }
        [Obsolete("startRotation property is deprecated. Use main.startRotation or main.startRotationMultiplier instead.", False)]
        public float startRotation { get; set; }
        [Obsolete("startRotation3D property is deprecated. Use main.startRotationX, main.startRotationY and main.startRotationZ instead. (Or main.startRotationXMultiplier, main.startRotationYMultiplier and main.startRotationZMultiplier).", False)]
        public Vector3 startRotation3D { get; set; }
        [Obsolete("startLifetime property is deprecated. Use main.startLifetime or main.startLifetimeMultiplier instead.", False)]
        public float startLifetime { get; set; }
        [Obsolete("gravityModifier property is deprecated. Use main.gravityModifier or main.gravityModifierMultiplier instead.", False)]
        public float gravityModifier { get; set; }
        [Obsolete("maxParticles property is deprecated. Use main.maxParticles instead.", False)]
        public int maxParticles { get; set; }
        [Obsolete("simulationSpace property is deprecated. Use main.simulationSpace instead.", False)]
        public ParticleSystemSimulationSpace simulationSpace { get; set; }
        [Obsolete("scalingMode property is deprecated. Use main.scalingMode instead.", False)]
        public ParticleSystemScalingMode scalingMode { get; set; }
        [Obsolete("automaticCullingEnabled property is deprecated. Use proceduralSimulationSupported instead (UnityUpgradable) -> proceduralSimulationSupported", True)]
        public bool automaticCullingEnabled { get; }
        public bool isPlaying { get; }
        public bool isEmitting { get; }
        public bool isStopped { get; }
        public bool isPaused { get; }
        public int particleCount { get; }
        public float time { get; set; }
        public uint randomSeed { get; set; }
        public bool useAutoRandomSeed { get; set; }
        public bool proceduralSimulationSupported { get; }
        public MainModule main { get; }
        public EmissionModule emission { get; }
        public ShapeModule shape { get; }
        public VelocityOverLifetimeModule velocityOverLifetime { get; }
        public LimitVelocityOverLifetimeModule limitVelocityOverLifetime { get; }
        public InheritVelocityModule inheritVelocity { get; }
        public LifetimeByEmitterSpeedModule lifetimeByEmitterSpeed { get; }
        public ForceOverLifetimeModule forceOverLifetime { get; }
        public ColorOverLifetimeModule colorOverLifetime { get; }
        public ColorBySpeedModule colorBySpeed { get; }
        public SizeOverLifetimeModule sizeOverLifetime { get; }
        public SizeBySpeedModule sizeBySpeed { get; }
        public RotationOverLifetimeModule rotationOverLifetime { get; }
        public RotationBySpeedModule rotationBySpeed { get; }
        public ExternalForcesModule externalForces { get; }
        public NoiseModule noise { get; }
        public CollisionModule collision { get; }
        public TriggerModule trigger { get; }
        public SubEmittersModule subEmitters { get; }
        public TextureSheetAnimationModule textureSheetAnimation { get; }
        public LightsModule lights { get; }
        public TrailModule trails { get; }
        public CustomDataModule customData { get; }

        [Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
        public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color);
        [Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
        public void Emit(Particle particle);
        [FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", ThrowsException = True, HasExplicitThis = True)]
        public void SetParticles(out Particle[] particles, int size, int offset);
        public void SetParticles(out Particle[] particles, int size);
        public void SetParticles(out Particle[] particles);
        public void SetParticles(out NativeArray<Particle> particles, int size, int offset);
        public void SetParticles(out NativeArray<Particle> particles, int size);
        public void SetParticles(out NativeArray<Particle> particles);
        [FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", ThrowsException = True, HasExplicitThis = True)]
        public int GetParticles([NotNull("ArgumentNullException")] out Particle[] particles, int size, int offset);
        public int GetParticles(out Particle[] particles, int size);
        public int GetParticles(out Particle[] particles);
        public int GetParticles(out NativeArray<Particle> particles, int size, int offset);
        public int GetParticles(out NativeArray<Particle> particles, int size);
        public int GetParticles(out NativeArray<Particle> particles);
        [FreeFunction(Name = "ParticleSystemScriptBindings::SetCustomParticleData", ThrowsException = True, HasExplicitThis = True)]
        public void SetCustomParticleData([NotNull("ArgumentNullException")] List<Vector4> customData, ParticleSystemCustomData streamIndex);
        [FreeFunction(Name = "ParticleSystemScriptBindings::GetCustomParticleData", ThrowsException = True, HasExplicitThis = True)]
        public int GetCustomParticleData([NotNull("ArgumentNullException")] List<Vector4> customData, ParticleSystemCustomData streamIndex);
        public PlaybackState GetPlaybackState();
        public void SetPlaybackState(PlaybackState playbackState);
        public Trails GetTrails();
        public int GetTrails(ref Trails trailData);
        [FreeFunction(Name = "ParticleSystemScriptBindings::SetTrailData", HasExplicitThis = True)]
        public void SetTrails(Trails trailData);
        [FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = True)]
        public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart, [DefaultValue("true")] bool fixedTimeStep);
        public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart);
        public void Simulate(float t, [DefaultValue("true")] bool withChildren);
        public void Simulate(float t);
        [FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = True)]
        public void Play([DefaultValue("true")] bool withChildren);
        public void Play();
        [FreeFunction(Name = "ParticleSystemScriptBindings::Pause", HasExplicitThis = True)]
        public void Pause([DefaultValue("true")] bool withChildren);
        public void Pause();
        [FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = True)]
        public void Stop([DefaultValue("true")] bool withChildren, [DefaultValue("ParticleSystemStopBehavior.StopEmitting")] ParticleSystemStopBehavior stopBehavior);
        public void Stop([DefaultValue("true")] bool withChildren);
        public void Stop();
        [FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = True)]
        public void Clear([DefaultValue("true")] bool withChildren);
        public void Clear();
        [FreeFunction(Name = "ParticleSystemScriptBindings::IsAlive", HasExplicitThis = True)]
        public bool IsAlive([DefaultValue("true")] bool withChildren);
        public bool IsAlive();
        [RequiredByNativeCode]
        public void Emit(int count);
        [NativeName("SyncJobs()->EmitParticlesExternal")]
        public void Emit(EmitParams emitParams, int count);
        public void TriggerSubEmitter(int subEmitterIndex);
        public void TriggerSubEmitter(int subEmitterIndex, ref Particle particle);
        [FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitter", HasExplicitThis = True)]
        public void TriggerSubEmitter(int subEmitterIndex, List<Particle> particles);
        [FreeFunction(Name = "ParticleSystemGeometryJob::ResetPreMappedBufferMemory")]
        public static void ResetPreMappedBufferMemory();
        [FreeFunction(Name = "ParticleSystemGeometryJob::SetMaximumPreMappedBufferCounts")]
        public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount);
        [NativeName("SetUsesAxisOfRotation")]
        public void AllocateAxisOfRotationAttribute();
        [NativeName("SetUsesMeshIndex")]
        public void AllocateMeshIndexAttribute();
        [NativeName("SetUsesCustomData")]
        public void AllocateCustomDataAttribute(ParticleSystemCustomData stream);
        [NativeType(CodegenOptions.Custom, "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
        public struct MinMaxCurve
        {

            public MinMaxCurve(float constant);
            public MinMaxCurve(float multiplier, AnimationCurve curve);
            public MinMaxCurve(float multiplier, AnimationCurve min, AnimationCurve max);
            public MinMaxCurve(float min, float max);

            [Obsolete("Please use MinMaxCurve.curveMultiplier instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/MinMaxCurve.curveMultiplier", False)]
            public float curveScalar { get; set; }
            public ParticleSystemCurveMode mode { get; set; }
            public float curveMultiplier { get; set; }
            public AnimationCurve curveMax { get; set; }
            public AnimationCurve curveMin { get; set; }
            public float constantMax { get; set; }
            public float constantMin { get; set; }
            public float constant { get; set; }
            public AnimationCurve curve { get; set; }

            public float Evaluate(float time);
            public float Evaluate(float time, float lerpFactor);

            public static implicit operator MinMaxCurve(float constant);
        }
        public struct MainModule
        {

            [Obsolete("Please use flipRotation instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/MainModule.flipRotation", False)]
            public float randomizeRotationDirection { get; set; }
            public Vector3 emitterVelocity { get; set; }
            public float duration { get; set; }
            public bool loop { get; set; }
            public bool prewarm { get; set; }
            public MinMaxCurve startDelay { get; set; }
            public float startDelayMultiplier { get; set; }
            public MinMaxCurve startLifetime { get; set; }
            public float startLifetimeMultiplier { get; set; }
            public MinMaxCurve startSpeed { get; set; }
            public float startSpeedMultiplier { get; set; }
            public bool startSize3D { get; set; }
            [NativeName("StartSizeX")]
            public MinMaxCurve startSize { get; set; }
            [NativeName("StartSizeXMultiplier")]
            public float startSizeMultiplier { get; set; }
            public MinMaxCurve startSizeX { get; set; }
            public float startSizeXMultiplier { get; set; }
            public MinMaxCurve startSizeY { get; set; }
            public float startSizeYMultiplier { get; set; }
            public MinMaxCurve startSizeZ { get; set; }
            public float startSizeZMultiplier { get; set; }
            public bool startRotation3D { get; set; }
            [NativeName("StartRotationZ")]
            public MinMaxCurve startRotation { get; set; }
            [NativeName("StartRotationZMultiplier")]
            public float startRotationMultiplier { get; set; }
            public MinMaxCurve startRotationX { get; set; }
            public float startRotationXMultiplier { get; set; }
            public MinMaxCurve startRotationY { get; set; }
            public float startRotationYMultiplier { get; set; }
            public MinMaxCurve startRotationZ { get; set; }
            public float startRotationZMultiplier { get; set; }
            public float flipRotation { get; set; }
            public MinMaxGradient startColor { get; set; }
            public MinMaxCurve gravityModifier { get; set; }
            public float gravityModifierMultiplier { get; set; }
            public ParticleSystemSimulationSpace simulationSpace { get; set; }
            public Transform customSimulationSpace { get; set; }
            public float simulationSpeed { get; set; }
            public bool useUnscaledTime { get; set; }
            public ParticleSystemScalingMode scalingMode { get; set; }
            public bool playOnAwake { get; set; }
            public int maxParticles { get; set; }
            public ParticleSystemEmitterVelocityMode emitterVelocityMode { get; set; }
            public ParticleSystemStopAction stopAction { get; set; }
            public ParticleSystemRingBufferMode ringBufferMode { get; set; }
            public Vector2 ringBufferLoopRange { get; set; }
            public ParticleSystemCullingMode cullingMode { get; set; }
        }
        public struct EmissionModule
        {

            [Obsolete("ParticleSystemEmissionType no longer does anything. Time and Distance based emission are now both always active.", False)]
            public ParticleSystemEmissionType type { get; set; }
            [Obsolete("rate property is deprecated. Use rateOverTime or rateOverDistance instead.", False)]
            public MinMaxCurve rate { get; set; }
            [Obsolete("rateMultiplier property is deprecated. Use rateOverTimeMultiplier or rateOverDistanceMultiplier instead.", False)]
            public float rateMultiplier { get; set; }
            public bool enabled { get; set; }
            public MinMaxCurve rateOverTime { get; set; }
            public float rateOverTimeMultiplier { get; set; }
            public MinMaxCurve rateOverDistance { get; set; }
            public float rateOverDistanceMultiplier { get; set; }
            public int burstCount { get; set; }

            public void SetBursts(Burst[] bursts);
            public void SetBursts(Burst[] bursts, int size);
            public int GetBursts(Burst[] bursts);
            [NativeThrows]
            public void SetBurst(int index, Burst burst);
            [NativeThrows]
            public Burst GetBurst(int index);
        }
        public struct ShapeModule
        {

            [Obsolete("Please use scale instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/ShapeModule.scale", False)]
            public Vector3 box { get; set; }
            [Obsolete("meshScale property is deprecated.Please use scale instead.", False)]
            public float meshScale { get; set; }
            [Obsolete("randomDirection property is deprecated. Use randomDirectionAmount instead.", False)]
            public bool randomDirection { get; set; }
            public bool enabled { get; set; }
            public ParticleSystemShapeType shapeType { get; set; }
            public float randomDirectionAmount { get; set; }
            public float sphericalDirectionAmount { get; set; }
            public float randomPositionAmount { get; set; }
            public bool alignToDirection { get; set; }
            public float radius { get; set; }
            public ParticleSystemShapeMultiModeValue radiusMode { get; set; }
            public float radiusSpread { get; set; }
            public MinMaxCurve radiusSpeed { get; set; }
            public float radiusSpeedMultiplier { get; set; }
            public float radiusThickness { get; set; }
            public float angle { get; set; }
            public float length { get; set; }
            public Vector3 boxThickness { get; set; }
            public ParticleSystemMeshShapeType meshShapeType { get; set; }
            public Mesh mesh { get; set; }
            public MeshRenderer meshRenderer { get; set; }
            public SkinnedMeshRenderer skinnedMeshRenderer { get; set; }
            public Sprite sprite { get; set; }
            public SpriteRenderer spriteRenderer { get; set; }
            public bool useMeshMaterialIndex { get; set; }
            public int meshMaterialIndex { get; set; }
            public bool useMeshColors { get; set; }
            public float normalOffset { get; set; }
            public ParticleSystemShapeMultiModeValue meshSpawnMode { get; set; }
            public float meshSpawnSpread { get; set; }
            public MinMaxCurve meshSpawnSpeed { get; set; }
            public float meshSpawnSpeedMultiplier { get; set; }
            public float arc { get; set; }
            public ParticleSystemShapeMultiModeValue arcMode { get; set; }
            public float arcSpread { get; set; }
            public MinMaxCurve arcSpeed { get; set; }
            public float arcSpeedMultiplier { get; set; }
            public float donutRadius { get; set; }
            public Vector3 position { get; set; }
            public Vector3 rotation { get; set; }
            public Vector3 scale { get; set; }
            public Texture2D texture { get; set; }
            public ParticleSystemShapeTextureChannel textureClipChannel { get; set; }
            public float textureClipThreshold { get; set; }
            public bool textureColorAffectsParticles { get; set; }
            public bool textureAlphaAffectsParticles { get; set; }
            public bool textureBilinearFiltering { get; set; }
            public int textureUVChannel { get; set; }
        }
        public struct CollisionModule
        {

            [Obsolete("The maxPlaneCount restriction has been removed. Please use planeCount instead to find out how many planes there are. (UnityUpgradable) -> UnityEngine.ParticleSystem/CollisionModule.planeCount", False)]
            public int maxPlaneCount { get; }
            public bool enabled { get; set; }
            public ParticleSystemCollisionType type { get; set; }
            public ParticleSystemCollisionMode mode { get; set; }
            public MinMaxCurve dampen { get; set; }
            public float dampenMultiplier { get; set; }
            public MinMaxCurve bounce { get; set; }
            public float bounceMultiplier { get; set; }
            public MinMaxCurve lifetimeLoss { get; set; }
            public float lifetimeLossMultiplier { get; set; }
            public float minKillSpeed { get; set; }
            public float maxKillSpeed { get; set; }
            public LayerMask collidesWith { get; set; }
            public bool enableDynamicColliders { get; set; }
            public int maxCollisionShapes { get; set; }
            public ParticleSystemCollisionQuality quality { get; set; }
            public float voxelSize { get; set; }
            public float radiusScale { get; set; }
            public bool sendCollisionMessages { get; set; }
            public float colliderForce { get; set; }
            public bool multiplyColliderForceByCollisionAngle { get; set; }
            public bool multiplyColliderForceByParticleSpeed { get; set; }
            public bool multiplyColliderForceByParticleSize { get; set; }
            [NativeThrows]
            public int planeCount { get; }
            [Obsolete("enableInteriorCollisions property is deprecated and is no longer required and has no effect on the particle system.", False)]
            public bool enableInteriorCollisions { get; set; }

            [NativeThrows]
            public void AddPlane(Transform transform);
            [NativeThrows]
            public void RemovePlane(int index);
            public void RemovePlane(Transform transform);
            [NativeThrows]
            public void SetPlane(int index, Transform transform);
            [NativeThrows]
            public Transform GetPlane(int index);
        }
        public struct TriggerModule
        {

            [Obsolete("The maxColliderCount restriction has been removed. Please use colliderCount instead to find out how many colliders there are. (UnityUpgradable) -> UnityEngine.ParticleSystem/TriggerModule.colliderCount", False)]
            public int maxColliderCount { get; }
            public bool enabled { get; set; }
            public ParticleSystemOverlapAction inside { get; set; }
            public ParticleSystemOverlapAction outside { get; set; }
            public ParticleSystemOverlapAction enter { get; set; }
            public ParticleSystemOverlapAction exit { get; set; }
            public ParticleSystemColliderQueryMode colliderQueryMode { get; set; }
            public float radiusScale { get; set; }
            [NativeThrows]
            public int colliderCount { get; }

            [NativeThrows]
            public void AddCollider(Component collider);
            [NativeThrows]
            public void RemoveCollider(int index);
            public void RemoveCollider(Component collider);
            [NativeThrows]
            public void SetCollider(int index, Component collider);
            [NativeThrows]
            public Component GetCollider(int index);
        }
        public struct SubEmittersModule
        {

            [Obsolete("birth0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", False)]
            public ParticleSystem birth0 { get; set; }
            [Obsolete("birth1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", False)]
            public ParticleSystem birth1 { get; set; }
            [Obsolete("collision0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", False)]
            public ParticleSystem collision0 { get; set; }
            [Obsolete("collision1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", False)]
            public ParticleSystem collision1 { get; set; }
            [Obsolete("death0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", False)]
            public ParticleSystem death0 { get; set; }
            [Obsolete("death1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", False)]
            public ParticleSystem death1 { get; set; }
            public bool enabled { get; set; }
            public int subEmittersCount { get; }

            [NativeThrows]
            public void AddSubEmitter(ParticleSystem subEmitter, ParticleSystemSubEmitterType type, ParticleSystemSubEmitterProperties properties, float emitProbability);
            public void AddSubEmitter(ParticleSystem subEmitter, ParticleSystemSubEmitterType type, ParticleSystemSubEmitterProperties properties);
            [NativeThrows]
            public void RemoveSubEmitter(int index);
            public void RemoveSubEmitter(ParticleSystem subEmitter);
            [NativeThrows]
            public void SetSubEmitterSystem(int index, ParticleSystem subEmitter);
            [NativeThrows]
            public void SetSubEmitterType(int index, ParticleSystemSubEmitterType type);
            [NativeThrows]
            public void SetSubEmitterProperties(int index, ParticleSystemSubEmitterProperties properties);
            [NativeThrows]
            public void SetSubEmitterEmitProbability(int index, float emitProbability);
            [NativeThrows]
            public ParticleSystem GetSubEmitterSystem(int index);
            [NativeThrows]
            public ParticleSystemSubEmitterType GetSubEmitterType(int index);
            [NativeThrows]
            public ParticleSystemSubEmitterProperties GetSubEmitterProperties(int index);
            [NativeThrows]
            public float GetSubEmitterEmitProbability(int index);
        }
        public struct TextureSheetAnimationModule
        {

            [Obsolete("flipU property is deprecated. Use ParticleSystemRenderer.flip.x instead.", False)]
            public float flipU { get; set; }
            [Obsolete("flipV property is deprecated. Use ParticleSystemRenderer.flip.y instead.", False)]
            public float flipV { get; set; }
            [Obsolete("useRandomRow property is deprecated. Use rowMode instead.", False)]
            public bool useRandomRow { get; set; }
            public bool enabled { get; set; }
            public ParticleSystemAnimationMode mode { get; set; }
            public ParticleSystemAnimationTimeMode timeMode { get; set; }
            public float fps { get; set; }
            public int numTilesX { get; set; }
            public int numTilesY { get; set; }
            public ParticleSystemAnimationType animation { get; set; }
            public ParticleSystemAnimationRowMode rowMode { get; set; }
            public MinMaxCurve frameOverTime { get; set; }
            public float frameOverTimeMultiplier { get; set; }
            public MinMaxCurve startFrame { get; set; }
            public float startFrameMultiplier { get; set; }
            public int cycleCount { get; set; }
            public int rowIndex { get; set; }
            public UVChannelFlags uvChannelMask { get; set; }
            public int spriteCount { get; }
            public Vector2 speedRange { get; set; }

            [NativeThrows]
            public void AddSprite(Sprite sprite);
            [NativeThrows]
            public void RemoveSprite(int index);
            [NativeThrows]
            public void SetSprite(int index, Sprite sprite);
            [NativeThrows]
            public Sprite GetSprite(int index);
        }
        [RequiredByNativeCode("particleSystemParticle", Optional = True)]
        public struct Particle
        {

            [Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", False)]
            public float lifetime { get; set; }
            [Obsolete("randomValue property is deprecated. Use randomSeed instead to control random behavior of particles.", False)]
            public float randomValue { get; set; }
            [Obsolete("size property is deprecated. Use startSize or GetCurrentSize() instead.", False)]
            public float size { get; set; }
            [Obsolete("color property is deprecated. Use startColor or GetCurrentColor() instead.", False)]
            public Color32 color { get; set; }
            public Vector3 position { get; set; }
            public Vector3 velocity { get; set; }
            public Vector3 animatedVelocity { get; }
            public Vector3 totalVelocity { get; }
            public float remainingLifetime { get; set; }
            public float startLifetime { get; set; }
            public Color32 startColor { get; set; }
            public uint randomSeed { get; set; }
            public Vector3 axisOfRotation { get; set; }
            public float startSize { get; set; }
            public Vector3 startSize3D { get; set; }
            public float rotation { get; set; }
            public Vector3 rotation3D { get; set; }
            public float angularVelocity { get; set; }
            public Vector3 angularVelocity3D { get; set; }

            public float GetCurrentSize(ParticleSystem system);
            public Vector3 GetCurrentSize3D(ParticleSystem system);
            public Color32 GetCurrentColor(ParticleSystem system);
            public void SetMeshIndex(int index);
            public int GetMeshIndex(ParticleSystem system);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("ParticleSystem.CollisionEvent has been deprecated. Use ParticleCollisionEvent instead (UnityUpgradable)", True)]
        public struct CollisionEvent
        {

            public Vector3 intersection { get; }
            public Vector3 normal { get; }
            public Vector3 velocity { get; }
            public Component collider { get; }
        }
        [NativeType(CodegenOptions.Custom, "MonoBurst", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
        public struct Burst
        {

            public Burst(float _time, short _count);
            public Burst(float _time, short _minCount, short _maxCount);
            public Burst(float _time, short _minCount, short _maxCount, int _cycleCount, float _repeatInterval);
            public Burst(float _time, MinMaxCurve _count);
            public Burst(float _time, MinMaxCurve _count, int _cycleCount, float _repeatInterval);

            public float time { get; set; }
            public MinMaxCurve count { get; set; }
            public short minCount { get; set; }
            public short maxCount { get; set; }
            public int cycleCount { get; set; }
            public float repeatInterval { get; set; }
            public float probability { get; set; }
        }
        [NativeType(CodegenOptions.Custom, "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
        public struct MinMaxGradient
        {

            public MinMaxGradient(Color color);
            public MinMaxGradient(Gradient gradient);
            public MinMaxGradient(Color min, Color max);
            public MinMaxGradient(Gradient min, Gradient max);

            public ParticleSystemGradientMode mode { get; set; }
            public Gradient gradientMax { get; set; }
            public Gradient gradientMin { get; set; }
            public Color colorMax { get; set; }
            public Color colorMin { get; set; }
            public Color color { get; set; }
            public Gradient gradient { get; set; }

            public Color Evaluate(float time);
            public Color Evaluate(float time, float lerpFactor);

            public static implicit operator MinMaxGradient(Color color);
            public static implicit operator MinMaxGradient(Gradient gradient);
        }
        public struct EmitParams
        {

            public Particle particle { get; set; }
            public Vector3 position { get; set; }
            public bool applyShapeToPosition { get; set; }
            public Vector3 velocity { get; set; }
            public float startLifetime { get; set; }
            public float startSize { get; set; }
            public Vector3 startSize3D { get; set; }
            public Vector3 axisOfRotation { get; set; }
            public float rotation { get; set; }
            public Vector3 rotation3D { get; set; }
            public float angularVelocity { get; set; }
            public Vector3 angularVelocity3D { get; set; }
            public Color32 startColor { get; set; }
            public uint randomSeed { get; set; }
            public int meshIndex { set; }

            public void ResetPosition();
            public void ResetVelocity();
            public void ResetAxisOfRotation();
            public void ResetRotation();
            public void ResetAngularVelocity();
            public void ResetStartSize();
            public void ResetStartColor();
            public void ResetRandomSeed();
            public void ResetStartLifetime();
            public void ResetMeshIndex();
        }
        public struct PlaybackState
        {
        }
        [NativeType(CodegenOptions.Custom, "MonoParticleTrails")]
        public struct Trails
        {

            public int capacity { get; set; }
        }
        public struct ColliderData
        {

            public int GetColliderCount(int particleIndex);
            public Component GetCollider(int particleIndex, int colliderIndex);
        }
        public struct VelocityOverLifetimeModule
        {

            public bool enabled { get; set; }
            public MinMaxCurve x { get; set; }
            public MinMaxCurve y { get; set; }
            public MinMaxCurve z { get; set; }
            public float xMultiplier { get; set; }
            public float yMultiplier { get; set; }
            public float zMultiplier { get; set; }
            public MinMaxCurve orbitalX { get; set; }
            public MinMaxCurve orbitalY { get; set; }
            public MinMaxCurve orbitalZ { get; set; }
            public float orbitalXMultiplier { get; set; }
            public float orbitalYMultiplier { get; set; }
            public float orbitalZMultiplier { get; set; }
            public MinMaxCurve orbitalOffsetX { get; set; }
            public MinMaxCurve orbitalOffsetY { get; set; }
            public MinMaxCurve orbitalOffsetZ { get; set; }
            public float orbitalOffsetXMultiplier { get; set; }
            public float orbitalOffsetYMultiplier { get; set; }
            public float orbitalOffsetZMultiplier { get; set; }
            public MinMaxCurve radial { get; set; }
            public float radialMultiplier { get; set; }
            public MinMaxCurve speedModifier { get; set; }
            public float speedModifierMultiplier { get; set; }
            public ParticleSystemSimulationSpace space { get; set; }
        }
        public struct LimitVelocityOverLifetimeModule
        {

            public bool enabled { get; set; }
            public MinMaxCurve limitX { get; set; }
            public float limitXMultiplier { get; set; }
            public MinMaxCurve limitY { get; set; }
            public float limitYMultiplier { get; set; }
            public MinMaxCurve limitZ { get; set; }
            public float limitZMultiplier { get; set; }
            [NativeName("Magnitude")]
            public MinMaxCurve limit { get; set; }
            [NativeName("MagnitudeMultiplier")]
            public float limitMultiplier { get; set; }
            public float dampen { get; set; }
            public bool separateAxes { get; set; }
            public ParticleSystemSimulationSpace space { get; set; }
            public MinMaxCurve drag { get; set; }
            public float dragMultiplier { get; set; }
            public bool multiplyDragByParticleSize { get; set; }
            public bool multiplyDragByParticleVelocity { get; set; }
        }
        public struct InheritVelocityModule
        {

            public bool enabled { get; set; }
            public ParticleSystemInheritVelocityMode mode { get; set; }
            public MinMaxCurve curve { get; set; }
            public float curveMultiplier { get; set; }
        }
        public struct LifetimeByEmitterSpeedModule
        {

            public bool enabled { get; set; }
            public MinMaxCurve curve { get; set; }
            public float curveMultiplier { get; set; }
            public Vector2 range { get; set; }
        }
        public struct ForceOverLifetimeModule
        {

            public bool enabled { get; set; }
            public MinMaxCurve x { get; set; }
            public MinMaxCurve y { get; set; }
            public MinMaxCurve z { get; set; }
            public float xMultiplier { get; set; }
            public float yMultiplier { get; set; }
            public float zMultiplier { get; set; }
            public ParticleSystemSimulationSpace space { get; set; }
            public bool randomized { get; set; }
        }
        public struct ColorOverLifetimeModule
        {

            public bool enabled { get; set; }
            public MinMaxGradient color { get; set; }
        }
        public struct ColorBySpeedModule
        {

            public bool enabled { get; set; }
            public MinMaxGradient color { get; set; }
            public Vector2 range { get; set; }
        }
        public struct SizeOverLifetimeModule
        {

            public bool enabled { get; set; }
            [NativeName("X")]
            public MinMaxCurve size { get; set; }
            [NativeName("XMultiplier")]
            public float sizeMultiplier { get; set; }
            public MinMaxCurve x { get; set; }
            public float xMultiplier { get; set; }
            public MinMaxCurve y { get; set; }
            public float yMultiplier { get; set; }
            public MinMaxCurve z { get; set; }
            public float zMultiplier { get; set; }
            public bool separateAxes { get; set; }
        }
        public struct SizeBySpeedModule
        {

            public bool enabled { get; set; }
            [NativeName("X")]
            public MinMaxCurve size { get; set; }
            [NativeName("XMultiplier")]
            public float sizeMultiplier { get; set; }
            public MinMaxCurve x { get; set; }
            public float xMultiplier { get; set; }
            public MinMaxCurve y { get; set; }
            public float yMultiplier { get; set; }
            public MinMaxCurve z { get; set; }
            public float zMultiplier { get; set; }
            public bool separateAxes { get; set; }
            public Vector2 range { get; set; }
        }
        public struct RotationOverLifetimeModule
        {

            public bool enabled { get; set; }
            public MinMaxCurve x { get; set; }
            public float xMultiplier { get; set; }
            public MinMaxCurve y { get; set; }
            public float yMultiplier { get; set; }
            public MinMaxCurve z { get; set; }
            public float zMultiplier { get; set; }
            public bool separateAxes { get; set; }
        }
        public struct RotationBySpeedModule
        {

            public bool enabled { get; set; }
            public MinMaxCurve x { get; set; }
            public float xMultiplier { get; set; }
            public MinMaxCurve y { get; set; }
            public float yMultiplier { get; set; }
            public MinMaxCurve z { get; set; }
            public float zMultiplier { get; set; }
            public bool separateAxes { get; set; }
            public Vector2 range { get; set; }
        }
        public struct ExternalForcesModule
        {

            public bool enabled { get; set; }
            public float multiplier { get; set; }
            public MinMaxCurve multiplierCurve { get; set; }
            public ParticleSystemGameObjectFilter influenceFilter { get; set; }
            public LayerMask influenceMask { get; set; }
            [NativeThrows]
            public int influenceCount { get; }

            public bool IsAffectedBy(ParticleSystemForceField field);
            [NativeThrows]
            public void AddInfluence([NotNull("ArgumentNullException")] ParticleSystemForceField field);
            public void RemoveInfluence(int index);
            [NativeThrows]
            public void RemoveInfluence([NotNull("ArgumentNullException")] ParticleSystemForceField field);
            [NativeThrows]
            public void RemoveAllInfluences();
            [NativeThrows]
            public void SetInfluence(int index, [NotNull("ArgumentNullException")] ParticleSystemForceField field);
            [NativeThrows]
            public ParticleSystemForceField GetInfluence(int index);
        }
        public struct NoiseModule
        {

            public bool enabled { get; set; }
            public bool separateAxes { get; set; }
            [NativeName("StrengthX")]
            public MinMaxCurve strength { get; set; }
            [NativeName("StrengthXMultiplier")]
            public float strengthMultiplier { get; set; }
            public MinMaxCurve strengthX { get; set; }
            public float strengthXMultiplier { get; set; }
            public MinMaxCurve strengthY { get; set; }
            public float strengthYMultiplier { get; set; }
            public MinMaxCurve strengthZ { get; set; }
            public float strengthZMultiplier { get; set; }
            public float frequency { get; set; }
            public bool damping { get; set; }
            public int octaveCount { get; set; }
            public float octaveMultiplier { get; set; }
            public float octaveScale { get; set; }
            public ParticleSystemNoiseQuality quality { get; set; }
            public MinMaxCurve scrollSpeed { get; set; }
            public float scrollSpeedMultiplier { get; set; }
            public bool remapEnabled { get; set; }
            [NativeName("RemapX")]
            public MinMaxCurve remap { get; set; }
            [NativeName("RemapXMultiplier")]
            public float remapMultiplier { get; set; }
            public MinMaxCurve remapX { get; set; }
            public float remapXMultiplier { get; set; }
            public MinMaxCurve remapY { get; set; }
            public float remapYMultiplier { get; set; }
            public MinMaxCurve remapZ { get; set; }
            public float remapZMultiplier { get; set; }
            public MinMaxCurve positionAmount { get; set; }
            public MinMaxCurve rotationAmount { get; set; }
            public MinMaxCurve sizeAmount { get; set; }
        }
        public struct LightsModule
        {

            public bool enabled { get; set; }
            public float ratio { get; set; }
            public bool useRandomDistribution { get; set; }
            public Light light { get; set; }
            public bool useParticleColor { get; set; }
            public bool sizeAffectsRange { get; set; }
            public bool alphaAffectsIntensity { get; set; }
            public MinMaxCurve range { get; set; }
            public float rangeMultiplier { get; set; }
            public MinMaxCurve intensity { get; set; }
            public float intensityMultiplier { get; set; }
            public int maxLights { get; set; }
        }
        public struct TrailModule
        {

            public bool enabled { get; set; }
            public ParticleSystemTrailMode mode { get; set; }
            public float ratio { get; set; }
            public MinMaxCurve lifetime { get; set; }
            public float lifetimeMultiplier { get; set; }
            public float minVertexDistance { get; set; }
            public ParticleSystemTrailTextureMode textureMode { get; set; }
            public bool worldSpace { get; set; }
            public bool dieWithParticles { get; set; }
            public bool sizeAffectsWidth { get; set; }
            public bool sizeAffectsLifetime { get; set; }
            public bool inheritParticleColor { get; set; }
            public MinMaxGradient colorOverLifetime { get; set; }
            public MinMaxCurve widthOverTrail { get; set; }
            public float widthOverTrailMultiplier { get; set; }
            public MinMaxGradient colorOverTrail { get; set; }
            public bool generateLightingData { get; set; }
            public int ribbonCount { get; set; }
            public float shadowBias { get; set; }
            public bool splitSubEmitterRibbons { get; set; }
            public bool attachRibbonsToTransform { get; set; }
        }
        public struct CustomDataModule
        {

            public bool enabled { get; set; }

            [NativeThrows]
            public void SetMode(ParticleSystemCustomData stream, ParticleSystemCustomDataMode mode);
            [NativeThrows]
            public ParticleSystemCustomDataMode GetMode(ParticleSystemCustomData stream);
            [NativeThrows]
            public void SetVectorComponentCount(ParticleSystemCustomData stream, int count);
            [NativeThrows]
            public int GetVectorComponentCount(ParticleSystemCustomData stream);
            [NativeThrows]
            public void SetVector(ParticleSystemCustomData stream, int component, MinMaxCurve curve);
            [NativeThrows]
            public MinMaxCurve GetVector(ParticleSystemCustomData stream, int component);
            [NativeThrows]
            public void SetColor(ParticleSystemCustomData stream, MinMaxGradient gradient);
            [NativeThrows]
            public MinMaxGradient GetColor(ParticleSystemCustomData stream);
        }
    }
}
