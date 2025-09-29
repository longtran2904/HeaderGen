#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using System.Reflection;
using UnityEngine.Internal;

namespace UnityEngine
{
    public sealed class Security
    {

        public Security();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This was an internal method which is no longer used", True)]
        public static Assembly LoadAndVerifyAssembly(byte[] assemblyData, string authorizationKey);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This was an internal method which is no longer used", True)]
        public static Assembly LoadAndVerifyAssembly(byte[] assemblyData);
        [ExcludeFromDocs]
        [Obsolete("Security.PrefetchSocketPolicy is no longer supported, since the Unity Web Player is no longer supported by Unity.", True)]
        public static bool PrefetchSocketPolicy(string ip, int atPort);
        [Obsolete("Security.PrefetchSocketPolicy is no longer supported, since the Unity Web Player is no longer supported by Unity.", True)]
        public static bool PrefetchSocketPolicy(string ip, int atPort, [DefaultValue("3000")] int timeout);
    }
}
