#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using System;
using UnityEditor.AssetImporters;
using UnityEngine;

namespace UnityEditor.Rendering
{
    [ScriptedImporter(2, "ies")]
    public class IESImporter : ScriptedImporter
    {
        public IESEngine engine;
        public IESMetaData iesMetaData;

        public IESImporter();

        public static event Action<AssetImportContext, string, bool, string, float, Light, Texture> createRenderPipelinePrefabLight;

        public override void OnImportAsset(AssetImportContext ctx);
    }
}
