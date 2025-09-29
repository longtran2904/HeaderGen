#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = True)]
    [RequiredByNativeCode]
    public sealed class RequireComponent : Attribute
    {

        public Type m_Type0;
        public Type m_Type1;
        public Type m_Type2;

        public RequireComponent(Type requiredComponent);
        public RequireComponent(Type requiredComponent, Type requiredComponent2);
        public RequireComponent(Type requiredComponent, Type requiredComponent2, Type requiredComponent3);
    }
}
