#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEditorInternal
{
    [RequiredByNativeCode]
    public sealed class ObjectMemoryStackInfo
    {

        public bool expanded;
        public bool sorted;
        public int allocated;
        public int ownedAllocated;
        public ObjectMemoryStackInfo[] callerSites;
        public string name;

        public ObjectMemoryStackInfo();
    }
}
