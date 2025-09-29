#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.Build.Player
{
    [NativeHeader("Modules/BuildPipeline/Editor/Public/TypeDB.h")]
    [UsedByNativeCode]
    public class TypeDB : IDisposable, ISerializable
    {
        protected TypeDB(SerializationInfo info, StreamingContext context);

        ~TypeDB();

        public void Dispose();
        protected virtual void Dispose(bool disposing);
        [NativeMethod(IsThreadSafe = True)]
        public Hash128 GetHash128();
        public override bool Equals(object obj);
        public override int GetHashCode();
        public void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}
