#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.VersionControl
{
    [NativeHeader("Editor/Src/VersionControl/VCChangeSet.h")]
    [NativeHeader("Editor/Src/VersionControl/VC_bindings.h")]
    [UsedByNativeCode]
    public class ChangeSet
    {
        public static string defaultID;

        public ChangeSet();
        public ChangeSet(string description);
        public ChangeSet(string description, string revision);
        public ChangeSet(ChangeSet other);

        ~ChangeSet();

        [NativeMethod(IsThreadSafe = True)]
        public string description { get; }
        [NativeMethod(IsThreadSafe = True)]
        public string id { get; }

        public void Dispose();
    }
}
