#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace JetBrains.Annotations
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = True)]
    [BaseTypeRequired(typeof(Attribute))]
    public sealed class BaseTypeRequiredAttribute : Attribute
    {

        public BaseTypeRequiredAttribute([NotNull] Type baseType);

        [NotNull]
        public Type BaseType { get; }
    }
}
