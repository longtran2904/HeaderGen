#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public struct StencilState : IEquatable<StencilState>
    {

        public StencilState(bool enabled = True, byte readMask = 255, byte writeMask = 255, CompareFunction compareFunction = CompareFunction.Always, StencilOp passOperation = StencilOp.Keep, StencilOp failOperation = StencilOp.Keep, StencilOp zFailOperation = StencilOp.Keep);
        public StencilState(bool enabled, byte readMask, byte writeMask, CompareFunction compareFunctionFront, StencilOp passOperationFront, StencilOp failOperationFront, StencilOp zFailOperationFront, CompareFunction compareFunctionBack, StencilOp passOperationBack, StencilOp failOperationBack, StencilOp zFailOperationBack);

        public static StencilState defaultValue { get; }
        public bool enabled { get; set; }
        public byte readMask { get; set; }
        public byte writeMask { get; set; }
        public CompareFunction compareFunctionFront { get; set; }
        public StencilOp passOperationFront { get; set; }
        public StencilOp failOperationFront { get; set; }
        public StencilOp zFailOperationFront { get; set; }
        public CompareFunction compareFunctionBack { get; set; }
        public StencilOp passOperationBack { get; set; }
        public StencilOp failOperationBack { get; set; }
        public StencilOp zFailOperationBack { get; set; }

        public void SetCompareFunction(CompareFunction value);
        public void SetPassOperation(StencilOp value);
        public void SetFailOperation(StencilOp value);
        public void SetZFailOperation(StencilOp value);
        public bool Equals(StencilState other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(StencilState left, StencilState right);
        public static bool operator !=(StencilState left, StencilState right);
    }
}
