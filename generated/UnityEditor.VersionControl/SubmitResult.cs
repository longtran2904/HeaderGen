#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.VersionControl
{
    [Flags]
    public enum SubmitResult
    {
        OK = 1,
        Error = 2,
        ConflictingFiles = 4,
        UnaddedFiles = 8
    }
}
