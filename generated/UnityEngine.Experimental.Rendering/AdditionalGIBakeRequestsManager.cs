#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
    public class AdditionalGIBakeRequestsManager
    {
        public AdditionalGIBakeRequestsManager();

        public static AdditionalGIBakeRequestsManager instance { get; }

        public int EnqueueRequest(Vector3 capturePosition);
        public void DequeueRequest(int requestID);
        public bool RetrieveProbeSH(int requestID, out SphericalHarmonicsL2 sh);
        public int UpdatePositionForRequest(int requestID, Vector3 newPosition);
    }
}
