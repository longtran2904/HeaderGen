#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [Obsolete("PostProcessAttribute has been renamed to CallbackOrderAttribute.")]
    [RequiredByNativeCode]
    public abstract class PostProcessAttribute : CallbackOrderAttribute
    {
        [Obsolete("PostProcessAttribute has been renamed. Use m_CallbackOrder of CallbackOrderAttribute.")]
        protected int m_PostprocessOrder;

        protected PostProcessAttribute();
    }
}
