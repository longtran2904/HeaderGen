#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditor.Build.Content
{
    [Flags]
    [NativeType("Modules/BuildPipeline/Editor/Shared/ContentDependencyCollector.h")]
    public enum DependencyType
    {

        RecursiveOperation = 1,
        MissingReferences = 2,
        ValidReferences = 4,
        DefaultDependencies = 5
    }
}
