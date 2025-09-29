#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace JetBrains.Annotations
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = True)]
    public sealed class MacroAttribute : Attribute
    {

        public MacroAttribute();

        [CanBeNull]
        public string Expression { get; set; }
        public int Editable { get; set; }
        [CanBeNull]
        public string Target { get; set; }
    }
}
