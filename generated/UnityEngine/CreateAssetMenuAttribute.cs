#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = False, Inherited = False)]
    public sealed class CreateAssetMenuAttribute : Attribute
    {

        public CreateAssetMenuAttribute();

        public string menuName { get; set; }
        public string fileName { get; set; }
        public int order { get; set; }
    }
}
