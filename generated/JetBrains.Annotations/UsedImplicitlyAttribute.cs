#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace JetBrains.Annotations
{
    [AttributeUsage(AttributeTargets.All, Inherited = False)]
    public sealed class UsedImplicitlyAttribute : Attribute
    {

        public UsedImplicitlyAttribute();
        public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags);
        public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags);
        public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags);

        public ImplicitUseKindFlags UseKindFlags { get; }
        public ImplicitUseTargetFlags TargetFlags { get; }
    }
}
