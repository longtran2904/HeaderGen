#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Lumin
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = False)]
    public sealed class UsesLuminPlatformLevelAttribute : Attribute
    {

        public UsesLuminPlatformLevelAttribute(uint platformLevel);

        public uint platformLevel { get; }
    }
}
