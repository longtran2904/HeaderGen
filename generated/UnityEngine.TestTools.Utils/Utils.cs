#region UnityEngine.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.TestRunner.dll
#endregion

namespace UnityEngine.TestTools.Utils
{
    public static class Utils
    {

        public static bool AreFloatsEqual(float expected, float actual, float epsilon);
        public static bool AreFloatsEqualAbsoluteError(float expected, float actual, float allowedAbsoluteError);
        public static GameObject CreatePrimitive(PrimitiveType type);
    }
}
