#region Unity.Mathematics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Mathematics.dll
#endregion

using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
    [Il2CppEagerStaticClassConstruction]
    public static class noise
    {

        public static float2 cellular(float2 P);
        public static float2 cellular2x2(float2 P);
        public static float2 cellular2x2x2(float3 P);
        public static float2 cellular(float3 P);
        public static float cnoise(float2 P);
        public static float pnoise(float2 P, float2 rep);
        public static float cnoise(float3 P);
        public static float pnoise(float3 P, float3 rep);
        public static float cnoise(float4 P);
        public static float pnoise(float4 P, float4 rep);
        public static float snoise(float2 v);
        public static float snoise(float3 v);
        public static float snoise(float3 v, out float3 gradient);
        public static float snoise(float4 v);
        public static float3 psrdnoise(float2 pos, float2 per, float rot);
        public static float3 psrdnoise(float2 pos, float2 per);
        public static float psrnoise(float2 pos, float2 per, float rot);
        public static float psrnoise(float2 pos, float2 per);
        public static float3 srdnoise(float2 pos, float rot);
        public static float3 srdnoise(float2 pos);
        public static float srnoise(float2 pos, float rot);
        public static float srnoise(float2 pos);
    }
}
