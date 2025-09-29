#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{
    public abstract class ObjectIndexer : SearchIndexer
    {
        public override IEnumerable<SearchResult> Search(string searchQuery, SearchContext context, SearchProvider provider, int maxScore = 2147483647, int patternMatchLimit = 2999);
        public override bool SkipEntry(string path, bool checkRoots = False);
        public override void IndexDocument(string id, bool checkIfDocumentExists);
        public void IndexWordComponents(int documentIndex, in string word);
        public void IndexPropertyComponents(int documentIndex, string name, string value);
        public virtual IEnumerable<string> GetEntryComponents(in string entry, int documentIndex);
        public void IndexWord(int documentIndex, in string word, int maxVariations, bool exact, int scoreModifier = 0);
        public void IndexWord(int documentIndex, in string word, bool exact = False, int scoreModifier = 0);
        public void IndexProperty(int documentIndex, string name, string value, bool saveKeyword, bool exact = False);
        public void IndexNumber(int documentIndex, string name, double number);
        protected void IndexObject(int documentIndex, UnityEngine.Object obj, bool dependencies = False);
    }
}
