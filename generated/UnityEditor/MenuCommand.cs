#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [RequiredByNativeCode]
    public sealed class MenuCommand
    {

        public UnityEngine.Object context;
        public int userData;

        public MenuCommand(UnityEngine.Object inContext, int inUserData);
        public MenuCommand(UnityEngine.Object inContext);
    }
}
