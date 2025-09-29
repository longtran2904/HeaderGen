#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Experimental.GlobalIllumination
{
    public struct DirectionalLight
    {

        public int instanceID;
        public bool shadow;
        public LightMode mode;
        public Vector3 position;
        public Quaternion orientation;
        public LinearColor color;
        public LinearColor indirectColor;
        public float penumbraWidthRadian;
        [Obsolete("Directional lights support cookies now. In order to position the cookie projection in the world, a position and full orientation are necessary. Use the position and orientation members instead of the direction parameter.", True)]
        public Vector3 direction;
    }
}
