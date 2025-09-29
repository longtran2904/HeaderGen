#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.VersionControl
{
    [NativeHeader("Editor/Src/VersionControl/VCAsset.h")]
    [NativeHeader("Editor/Src/VersionControl/VC_bindings.h")]
    [UsedByNativeCode]
    public class Asset
    {
        public Asset(string clientPath);

        ~Asset();

        public States state { get; }
        [NativeMethod(IsThreadSafe = True)]
        public string path { get; }
        [NativeMethod(IsThreadSafe = True)]
        public string metaPath { get; }
        [NativeMethod(IsThreadSafe = True)]
        public string assetPath { get; }
        [NativeMethod(IsThreadSafe = True)]
        public bool isFolder { get; }
        [NativeMethod(IsThreadSafe = True)]
        public bool readOnly { get; }
        [NativeMethod(IsThreadSafe = True)]
        public bool isMeta { get; }
        [NativeMethod(IsThreadSafe = True)]
        public bool locked { get; }
        [NativeMethod(IsThreadSafe = True)]
        public string name { get; }
        [NativeMethod(IsThreadSafe = True)]
        public string fullName { get; }
        [NativeMethod(IsThreadSafe = True)]
        public bool isInCurrentProject { get; }
        public string prettyPath { get; }

        public void Dispose();
        [NativeMethod(IsThreadSafe = True)]
        [NativeName("MonoIsChildOf")]
        public bool IsChildOf(Asset other);
        public bool IsState(States state);
        public bool IsOneOfStates(States[] states);
        public void Edit();
        public UnityEngine.Object Load();

        [Flags]
        public enum States
        {
            None = 0,
            Local = 1,
            Synced = 2,
            OutOfSync = 4,
            Missing = 8,
            CheckedOutLocal = 16,
            CheckedOutRemote = 32,
            DeletedLocal = 64,
            DeletedRemote = 128,
            AddedLocal = 256,
            AddedRemote = 512,
            Conflicted = 1024,
            LockedLocal = 2048,
            LockedRemote = 4096,
            Updating = 8192,
            ReadOnly = 16384,
            MetaFile = 32768,
            MovedLocal = 65536,
            MovedRemote = 131072,
            Unversioned = 262144,
            Exclusive = 524288
        }
    }
}
