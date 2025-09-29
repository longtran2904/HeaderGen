#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    public enum WebGLLinkerTarget
    {

        Asm = 0,
        Wasm = 1,
        [Obsolete("WebGLLinkerTarget.Both mode is no longer supported. Instead you can create separate asm.js and WebAssembly builds and download the appropriate one depending on the browser capabilities.", True)]
        Both = 2
    }
}
