#region UnityEngine.VFXModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VFXModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine.VFX
{
    [NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectBindings.h")]
    [NativeHeader("Modules/VFX/Public/VisualEffect.h")]
    [RequireComponent(typeof(Transform))]
    public class VisualEffect : Behaviour
    {

        public Action<VFXOutputEventArgs> outputEventReceived;

        public VisualEffect();

        public bool pause { get; set; }
        public float playRate { get; set; }
        public uint startSeed { get; set; }
        public bool resetSeedOnPlay { get; set; }
        public int initialEventID { get; set; }
        public string initialEventName { get; set; }
        public bool culled { get; }
        public VisualEffectAsset visualEffectAsset { get; set; }
        public int aliveParticleCount { get; }

        public VFXEventAttribute CreateVFXEventAttribute();
        public void SendEvent(int eventNameID, VFXEventAttribute eventAttribute);
        public void SendEvent(string eventName, VFXEventAttribute eventAttribute);
        public void SendEvent(int eventNameID);
        public void SendEvent(string eventName);
        public void Play(VFXEventAttribute eventAttribute);
        public void Play();
        public void Stop(VFXEventAttribute eventAttribute);
        public void Stop();
        public void Reinit();
        public void AdvanceOneFrame();
        [FreeFunction(Name = "VisualEffectBindings::ResetOverrideFromScript", HasExplicitThis = True)]
        public void ResetOverride(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::GetTextureDimensionFromScript", HasExplicitThis = True)]
        public TextureDimension GetTextureDimension(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<bool>", HasExplicitThis = True)]
        public bool HasBool(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<int>", HasExplicitThis = True)]
        public bool HasInt(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<UInt32>", HasExplicitThis = True)]
        public bool HasUInt(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<float>", HasExplicitThis = True)]
        public bool HasFloat(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Vector2f>", HasExplicitThis = True)]
        public bool HasVector2(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Vector3f>", HasExplicitThis = True)]
        public bool HasVector3(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Vector4f>", HasExplicitThis = True)]
        public bool HasVector4(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Matrix4x4f>", HasExplicitThis = True)]
        public bool HasMatrix4x4(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Texture*>", HasExplicitThis = True)]
        public bool HasTexture(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<AnimationCurve*>", HasExplicitThis = True)]
        public bool HasAnimationCurve(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Gradient*>", HasExplicitThis = True)]
        public bool HasGradient(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<Mesh*>", HasExplicitThis = True)]
        public bool HasMesh(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<SkinnedMeshRenderer*>", HasExplicitThis = True)]
        public bool HasSkinnedMeshRenderer(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::HasValueFromScript<GraphicsBuffer*>", HasExplicitThis = True)]
        public bool HasGraphicsBuffer(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<bool>", HasExplicitThis = True)]
        public void SetBool(int nameID, bool b);
        [FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<int>", HasExplicitThis = True)]
        public void SetInt(int nameID, int i);
        [FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<UInt32>", HasExplicitThis = True)]
        public void SetUInt(int nameID, uint i);
        [FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<float>", HasExplicitThis = True)]
        public void SetFloat(int nameID, float f);
        [FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Vector2f>", HasExplicitThis = True)]
        public void SetVector2(int nameID, Vector2 v);
        [FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Vector3f>", HasExplicitThis = True)]
        public void SetVector3(int nameID, Vector3 v);
        [FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Vector4f>", HasExplicitThis = True)]
        public void SetVector4(int nameID, Vector4 v);
        [FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Matrix4x4f>", HasExplicitThis = True)]
        public void SetMatrix4x4(int nameID, Matrix4x4 v);
        [FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Texture*>", HasExplicitThis = True)]
        public void SetTexture(int nameID, [NotNull("ArgumentNullException")] Texture t);
        [FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<AnimationCurve*>", HasExplicitThis = True)]
        public void SetAnimationCurve(int nameID, [NotNull("ArgumentNullException")] AnimationCurve c);
        [FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Gradient*>", HasExplicitThis = True)]
        public void SetGradient(int nameID, [NotNull("ArgumentNullException")] Gradient g);
        [FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<Mesh*>", HasExplicitThis = True)]
        public void SetMesh(int nameID, [NotNull("ArgumentNullException")] Mesh m);
        [FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<SkinnedMeshRenderer*>", HasExplicitThis = True)]
        public void SetSkinnedMeshRenderer(int nameID, SkinnedMeshRenderer m);
        [FreeFunction(Name = "VisualEffectBindings::SetValueFromScript<GraphicsBuffer*>", HasExplicitThis = True)]
        public void SetGraphicsBuffer(int nameID, GraphicsBuffer g);
        [FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<bool>", HasExplicitThis = True)]
        public bool GetBool(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<int>", HasExplicitThis = True)]
        public int GetInt(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<UInt32>", HasExplicitThis = True)]
        public uint GetUInt(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<float>", HasExplicitThis = True)]
        public float GetFloat(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<Vector2f>", HasExplicitThis = True)]
        public Vector2 GetVector2(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<Vector3f>", HasExplicitThis = True)]
        public Vector3 GetVector3(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<Vector4f>", HasExplicitThis = True)]
        public Vector4 GetVector4(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<Matrix4x4f>", HasExplicitThis = True)]
        public Matrix4x4 GetMatrix4x4(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<Texture*>", HasExplicitThis = True)]
        public Texture GetTexture(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<Mesh*>", HasExplicitThis = True)]
        public Mesh GetMesh(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::GetValueFromScript<SkinnedMeshRenderer*>", HasExplicitThis = True)]
        public SkinnedMeshRenderer GetSkinnedMeshRenderer(int nameID);
        public Gradient GetGradient(int nameID);
        public AnimationCurve GetAnimationCurve(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::HasSystemFromScript", HasExplicitThis = True)]
        public bool HasSystem(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::GetParticleSystemInfo", ThrowsException = True, HasExplicitThis = True)]
        public VFXParticleSystemInfo GetParticleSystemInfo(int nameID);
        public bool HasAnySystemAwake();
        public void GetSpawnSystemInfo(int nameID, VFXSpawnerState spawnState);
        public VFXSpawnerState GetSpawnSystemInfo(int nameID);
        [FreeFunction(Name = "VisualEffectBindings::GetSystemNamesFromScript", HasExplicitThis = True)]
        public void GetSystemNames([NotNull("ArgumentNullException")] List<string> names);
        [FreeFunction(Name = "VisualEffectBindings::GetParticleSystemNamesFromScript", HasExplicitThis = True)]
        public void GetParticleSystemNames([NotNull("ArgumentNullException")] List<string> names);
        [FreeFunction(Name = "VisualEffectBindings::GetOutputEventNamesFromScript", HasExplicitThis = True)]
        public void GetOutputEventNames([NotNull("ArgumentNullException")] List<string> names);
        [FreeFunction(Name = "VisualEffectBindings::GetSpawnSystemNamesFromScript", HasExplicitThis = True)]
        public void GetSpawnSystemNames([NotNull("ArgumentNullException")] List<string> names);
        public void ResetOverride(string name);
        public bool HasInt(string name);
        public bool HasUInt(string name);
        public bool HasFloat(string name);
        public bool HasVector2(string name);
        public bool HasVector3(string name);
        public bool HasVector4(string name);
        public bool HasMatrix4x4(string name);
        public bool HasTexture(string name);
        public TextureDimension GetTextureDimension(string name);
        public bool HasAnimationCurve(string name);
        public bool HasGradient(string name);
        public bool HasMesh(string name);
        public bool HasSkinnedMeshRenderer(string name);
        public bool HasGraphicsBuffer(string name);
        public bool HasBool(string name);
        public void SetInt(string name, int i);
        public void SetUInt(string name, uint i);
        public void SetFloat(string name, float f);
        public void SetVector2(string name, Vector2 v);
        public void SetVector3(string name, Vector3 v);
        public void SetVector4(string name, Vector4 v);
        public void SetMatrix4x4(string name, Matrix4x4 v);
        public void SetTexture(string name, Texture t);
        public void SetAnimationCurve(string name, AnimationCurve c);
        public void SetGradient(string name, Gradient g);
        public void SetMesh(string name, Mesh m);
        public void SetSkinnedMeshRenderer(string name, SkinnedMeshRenderer m);
        public void SetGraphicsBuffer(string name, GraphicsBuffer g);
        public void SetBool(string name, bool b);
        public int GetInt(string name);
        public uint GetUInt(string name);
        public float GetFloat(string name);
        public Vector2 GetVector2(string name);
        public Vector3 GetVector3(string name);
        public Vector4 GetVector4(string name);
        public Matrix4x4 GetMatrix4x4(string name);
        public Texture GetTexture(string name);
        public Mesh GetMesh(string name);
        public SkinnedMeshRenderer GetSkinnedMeshRenderer(string name);
        public bool GetBool(string name);
        public AnimationCurve GetAnimationCurve(string name);
        public Gradient GetGradient(string name);
        public bool HasSystem(string name);
        public VFXParticleSystemInfo GetParticleSystemInfo(string name);
        public VFXSpawnerState GetSpawnSystemInfo(string name);
        public void Simulate(float stepDeltaTime, uint stepCount = 1);
    }
}
