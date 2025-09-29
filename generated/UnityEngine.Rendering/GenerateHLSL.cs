#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
    public class GenerateHLSL : Attribute
    {

        public PackingRules packingRules;
        public bool containsPackedFields;
        public bool needAccessors;
        public bool needSetters;
        public bool needParamDebug;
        public int paramDefinesStart;
        public bool omitStructDeclaration;
        public bool generateCBuffer;
        public int constantRegister;
        public string sourcePath;

        public GenerateHLSL(PackingRules rules = PackingRules.Exact, bool needAccessors = True, bool needSetters = False, bool needParamDebug = False, int paramDefinesStart = 1, bool omitStructDeclaration = False, bool containsPackedFields = False, bool generateCBuffer = False, int constantRegister = -1, string sourcePath = null);
    }
}
