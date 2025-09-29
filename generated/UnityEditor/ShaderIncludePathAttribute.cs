#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [AttributeUsage(AttributeTargets.Method)]
    [Obsolete("[ShaderIncludePath] attribute is no longer supported. Your shader library must be under the Assets folder or in a package. To include shader headers directly from a package, use #include \"Packages/<package name>/<path to your header file>\"", True)]
    public class ShaderIncludePathAttribute : Attribute
    {

        public ShaderIncludePathAttribute();
    }
}
