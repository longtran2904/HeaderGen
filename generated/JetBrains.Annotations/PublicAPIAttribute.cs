#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace JetBrains.Annotations
{
    [AttributeUsage(AttributeTargets.All, Inherited = False)]
    [MeansImplicitUse(ImplicitUseTargetFlags.WithMembers)]
    public sealed class PublicAPIAttribute : Attribute
    {

        public PublicAPIAttribute();
        public PublicAPIAttribute([NotNull] string comment);

        [CanBeNull]
        public string Comment { get; }
    }
}
