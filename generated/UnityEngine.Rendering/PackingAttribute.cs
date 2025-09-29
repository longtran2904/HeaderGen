#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = True)]
    public class PackingAttribute : Attribute
    {

        public string[] displayNames;
        public float[] range;
        public FieldPacking packingScheme;
        public int offsetInSource;
        public int sizeInBits;
        public bool isDirection;
        public bool sRGBDisplay;
        public bool checkIsNormalized;
        public string preprocessor;

        public PackingAttribute(string[] displayNames, FieldPacking packingScheme = FieldPacking.NoPacking, int bitSize = 32, int offsetInSource = 0, float minValue = 0, float maxValue = 1, bool isDirection = False, bool sRGBDisplay = False, bool checkIsNormalized = False, string preprocessor = "");
        public PackingAttribute(string displayName = "", FieldPacking packingScheme = FieldPacking.NoPacking, int bitSize = 0, int offsetInSource = 0, float minValue = 0, float maxValue = 1, bool isDirection = False, bool sRGBDisplay = False, bool checkIsNormalized = False, string preprocessor = "");
    }
}
