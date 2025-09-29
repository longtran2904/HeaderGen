#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Internal;

namespace UnityEditor
{
    [ExcludeFromDocs]
    public class RootEditorAttribute : Attribute
    {

        public bool supportsAddComponent;

        public RootEditorAttribute(bool supportsAddComponent = False);
        public delegate Type RootEditorHandler(UnityEngine.Object[] objects);
    }
}
