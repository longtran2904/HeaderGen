#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.Build.Content
{
    [NativeHeader("Modules/BuildPipeline/Editor/Public/BuildUsageTagSet.h")]
    [UsedByNativeCode]
    public class BuildUsageTagSet : IDisposable, ISerializable
    {

        public BuildUsageTagSet();
        protected BuildUsageTagSet(System.Runtime.Serialization.SerializationInfo info, StreamingContext context);

        ~BuildUsageTagSet();

        public void Dispose();
        protected virtual void Dispose(bool disposing);
        [NativeMethod(IsThreadSafe = True)]
        public Hash128 GetHash128();
        [NativeMethod(IsThreadSafe = True)]
        public ObjectIdentifier[] GetObjectIdentifiers();
        [NativeMethod(IsThreadSafe = True)]
        public void UnionWith(BuildUsageTagSet other);
        [NativeMethod(IsThreadSafe = True)]
        public void FilterToSubset(ObjectIdentifier[] objectIds);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, StreamingContext context);
    }
}
