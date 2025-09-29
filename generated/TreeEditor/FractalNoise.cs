#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace TreeEditor
{
    public class FractalNoise
    {

        public FractalNoise(float inH, float inLacunarity, float inOctaves);
        public FractalNoise(float inH, float inLacunarity, float inOctaves, Perlin noise);

        public float HybridMultifractal(float x, float y, float offset);
        public float RidgedMultifractal(float x, float y, float offset, float gain);
        public float BrownianMotion(float x, float y);
    }
}
