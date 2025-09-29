#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D
{
    [MovedFrom("UnityEngine.Experimental.U2D")]
    [NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
    [NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
    [NativeType(CodegenOptions.Custom, "ScriptingSpriteBone")]
    [RequiredByNativeCode]
    public struct SpriteBone
    {

        public string name { get; set; }
        public string guid { get; set; }
        public Vector3 position { get; set; }
        public Quaternion rotation { get; set; }
        public float length { get; set; }
        public int parentId { get; set; }
        public Color32 color { get; set; }
    }
}
