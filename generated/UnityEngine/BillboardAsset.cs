#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/Billboard/BillboardAsset.h")]
    [NativeHeader("Runtime/Export/Graphics/BillboardRenderer.bindings.h")]
    public sealed class BillboardAsset : Object
    {
        public BillboardAsset();

        public float width { get; set; }
        public float height { get; set; }
        public float bottom { get; set; }
        public int imageCount { get; }
        public int vertexCount { get; }
        public int indexCount { get; }
        public Material material { get; set; }

        public void GetImageTexCoords(List<Vector4> imageTexCoords);
        [NativeMethod("GetBillboardDataReadonly().GetImageTexCoords")]
        public Vector4[] GetImageTexCoords();
        public void SetImageTexCoords(List<Vector4> imageTexCoords);
        [FreeFunction(Name = "BillboardRenderer_Bindings::SetImageTexCoords", HasExplicitThis = True)]
        public void SetImageTexCoords([NotNull("ArgumentNullException")][Unmarshalled] Vector4[] imageTexCoords);
        public void GetVertices(List<Vector2> vertices);
        [NativeMethod("GetBillboardDataReadonly().GetVertices")]
        public Vector2[] GetVertices();
        public void SetVertices(List<Vector2> vertices);
        [FreeFunction(Name = "BillboardRenderer_Bindings::SetVertices", HasExplicitThis = True)]
        public void SetVertices([NotNull("ArgumentNullException")][Unmarshalled] Vector2[] vertices);
        public void GetIndices(List<ushort> indices);
        [NativeMethod("GetBillboardDataReadonly().GetIndices")]
        public ushort[] GetIndices();
        public void SetIndices(List<ushort> indices);
        [FreeFunction(Name = "BillboardRenderer_Bindings::SetIndices", HasExplicitThis = True)]
        public void SetIndices([NotNull("ArgumentNullException")][Unmarshalled] ushort[] indices);
    }
}
