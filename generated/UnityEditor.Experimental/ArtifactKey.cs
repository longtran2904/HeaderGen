#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditor.Experimental
{
    [NativeHeader("Modules/AssetDatabase/Editor/Public/AssetDatabaseExperimental.h")]
    public struct ArtifactKey
    {
        public GUID guid;
        public Type importerType;

        public ArtifactKey(GUID g);
        public ArtifactKey(GUID guid, Type importerType);

        public bool isValid { get; }
    }
}
