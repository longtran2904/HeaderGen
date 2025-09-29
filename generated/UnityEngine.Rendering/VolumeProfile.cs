#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
    [CoreRPHelpURL("Volume-Profile", "com.unity.render-pipelines.high-definition")]
    public sealed class VolumeProfile : ScriptableObject
    {

        public List<VolumeComponent> components;
        [NonSerialized]
        public bool isDirty;

        public VolumeProfile();

        public void Reset();
        public T Add<T>(bool overrides = False) where T : VolumeComponent;
        public VolumeComponent Add(Type type, bool overrides = False);
        public void Remove<T>() where T : VolumeComponent;
        public void Remove(Type type);
        public bool Has<T>() where T : VolumeComponent;
        public bool Has(Type type);
        public bool HasSubclassOf(Type type);
        public bool TryGet<T>(out T component) where T : VolumeComponent;
        public bool TryGet<T>(Type type, out T component) where T : VolumeComponent;
        public bool TryGetSubclassOf<T>(Type type, out T component) where T : VolumeComponent;
        public bool TryGetAllSubclassOf<T>(Type type, List<T> result) where T : VolumeComponent;
        public override int GetHashCode();
    }
}
