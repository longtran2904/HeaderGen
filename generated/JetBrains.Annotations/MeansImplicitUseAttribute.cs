#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace JetBrains.Annotations
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
    public sealed class MeansImplicitUseAttribute : Attribute
    {

        public MeansImplicitUseAttribute();
        public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags);
        public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags);
        public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags);

        [UsedImplicitly]
        public ImplicitUseKindFlags UseKindFlags { get; }
        [UsedImplicitly]
        public ImplicitUseTargetFlags TargetFlags { get; }
    }
}
