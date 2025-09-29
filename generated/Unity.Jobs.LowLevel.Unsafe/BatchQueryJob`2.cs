#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using Unity.Collections;

namespace Unity.Jobs.LowLevel.Unsafe
{
    public struct BatchQueryJob<CommandT, ResultT> where CommandT : struct where ResultT : struct
    {

        public BatchQueryJob(NativeArray<CommandT> commands, NativeArray<ResultT> results);
    }
}
