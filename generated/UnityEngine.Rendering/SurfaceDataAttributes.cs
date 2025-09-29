#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    [AttributeUsage(AttributeTargets.Field)]
    public class SurfaceDataAttributes : Attribute
    {
        public string[] displayNames;
        public bool isDirection;
        public bool sRGBDisplay;
        public FieldPrecision precision;
        public bool checkIsNormalized;
        public string preprocessor;

        public SurfaceDataAttributes(string displayName = "", bool isDirection = False, bool sRGBDisplay = False, FieldPrecision precision = FieldPrecision.Default, bool checkIsNormalized = False, string preprocessor = "");
        public SurfaceDataAttributes(string[] displayNames, bool isDirection = False, bool sRGBDisplay = False, FieldPrecision precision = FieldPrecision.Default, bool checkIsNormalized = False, string preprocessor = "");
    }
}
