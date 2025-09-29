#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = True, Inherited = False)]
    public sealed class CustomPropertyDrawer : Attribute
    {

        public CustomPropertyDrawer(Type type);
        public CustomPropertyDrawer(Type type, bool useForChildren);
    }
}
