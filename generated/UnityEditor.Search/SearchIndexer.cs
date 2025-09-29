#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.IO;

namespace UnityEditor.Search
{
    public class SearchIndexer
    {

        public SearchIndexer();
        public SearchIndexer(string name);

        public string name { get; set; }
        public int keywordCount { get; }
        public int documentCount { get; }
        public Func<string, bool> skipEntryHandler { get; set; }
        public Func<string, string> resolveDocumentHandler { get; set; }
        public int minWordIndexationLength { get; set; }

        public void AddWord(string word, int score, int documentIndex);
        public void AddWord(string word, int size, int score, int documentIndex);
        public void AddExactWord(string word, int score, int documentIndex);
        public void AddWord(string word, int minVariations, int maxVariations, int score, int documentIndex);
        public void AddNumber(string key, double value, int score, int documentIndex);
        public void AddProperty(string key, string value, int documentIndex, bool saveKeyword = False, bool exact = True);
        public void AddProperty(string key, string value, int score, int documentIndex, bool saveKeyword = False, bool exact = True);
        public void AddProperty(string name, string value, int minVariations, int maxVariations, int score, int documentIndex, bool saveKeyword = False, bool exact = True);
        public bool IsReady();
        public virtual IEnumerable<SearchResult> Search(string query, int maxScore = 2147483647, int patternMatchLimit = 2999);
        public virtual IEnumerable<SearchResult> Search(SearchContext context, SearchProvider provider, int maxScore = 2147483647, int patternMatchLimit = 2999);
        public virtual IEnumerable<SearchResult> Search(string query, SearchContext context, SearchProvider provider, int maxScore = 2147483647, int patternMatchLimit = 2999);
        public void Write(Stream stream);
        public byte[] SaveBytes();
        public bool Read(Stream stream, bool checkVersionOnly);
        public bool LoadBytes(byte[] bytes, Action<bool> finished);
        public virtual bool SkipEntry(string document, bool checkRoots = False);
        public virtual void IndexDocument(string document, bool checkIfDocumentExists);
        public SearchDocument GetDocument(int index);
        public int AddDocument(string document, bool checkIfExists = True);
        public void SetMetaInfo(string documentId, string metadata);
        public string GetMetaInfo(string documentId);
        public void Start(bool clear = False);
        public void Finish();
        public void Finish(Action threadCompletedCallback);
        public void Finish(Action<byte[]> threadCompletedCallback, string[] removedDocuments);
    }
}
