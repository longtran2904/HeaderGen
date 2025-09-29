#region UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextRenderingModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/TextRendering/TextGenerator.h")]
    [UsedByNativeCode]
    public sealed class TextGenerator : IDisposable
    {

        public TextGenerator();
        public TextGenerator(int initialCapacity);

        ~TextGenerator();

        public int characterCountVisible { get; }
        public IList<UIVertex> verts { get; }
        public IList<UICharInfo> characters { get; }
        public IList<UILineInfo> lines { get; }
        public Rect rectExtents { get; }
        public int vertexCount { get; }
        public int characterCount { get; }
        public int lineCount { get; }
        [NativeProperty("FontSizeFoundForBestFit", False, TargetType.Function)]
        public int fontSizeUsedForBestFit { get; }

        public void Invalidate();
        public void GetCharacters(List<UICharInfo> characters);
        public void GetLines(List<UILineInfo> lines);
        public void GetVertices(List<UIVertex> vertices);
        public float GetPreferredWidth(string str, TextGenerationSettings settings);
        public float GetPreferredHeight(string str, TextGenerationSettings settings);
        public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context);
        public bool Populate(string str, TextGenerationSettings settings);
        public UIVertex[] GetVerticesArray();
        public UICharInfo[] GetCharactersArray();
        public UILineInfo[] GetLinesArray();
    }
}
