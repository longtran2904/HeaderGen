#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.Experimental.RestService
{
    [Obsolete("This type is obsolete and will be deleted.", True)]
    public class PlayerDataFileLocator
    {

        public PlayerDataFileLocator();

        public static void Register(Locator locator);
        public delegate bool Locator(ref string path);
    }
}
