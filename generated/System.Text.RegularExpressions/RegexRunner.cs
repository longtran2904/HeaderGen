#region System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Text.RegularExpressions.dll
#endregion

using System.ComponentModel;

namespace System.Text.RegularExpressions
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class RegexRunner
    {

        protected internal int runtextbeg;
        protected internal int runtextend;
        protected internal int runtextstart;
        protected internal string runtext;
        protected internal int runtextpos;
        protected internal int[] runtrack;
        protected internal int runtrackpos;
        protected internal int[] runstack;
        protected internal int runstackpos;
        protected internal int[] runcrawl;
        protected internal int runcrawlpos;
        protected internal int runtrackcount;
        protected internal Match runmatch;
        protected internal Regex runregex;

        protected RegexRunner();

        protected internal virtual void Scan(ReadOnlySpan<char> text);
        [Obsolete("This API supports obsolete mechanisms for Regex extensibility. It is not supported.", DiagnosticId = "SYSLIB0052", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick);
        [Obsolete("This API supports obsolete mechanisms for Regex extensibility. It is not supported.", DiagnosticId = "SYSLIB0052", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout);
        protected internal void CheckTimeout();
        protected virtual void Go();
        protected virtual bool FindFirstChar();
        protected virtual void InitTrackCount();
        protected void EnsureStorage();
        protected bool IsBoundary(int index, int startpos, int endpos);
        protected bool IsECMABoundary(int index, int startpos, int endpos);
        [Obsolete("This API supports obsolete mechanisms for Regex extensibility. It is not supported.", DiagnosticId = "SYSLIB0052", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected static bool CharInSet(char ch, string set, string category);
        public static bool CharInClass(char ch, string charClass);
        protected void DoubleTrack();
        protected void DoubleStack();
        protected void DoubleCrawl();
        protected void Crawl(int i);
        protected int Popcrawl();
        protected int Crawlpos();
        protected void Capture(int capnum, int start, int end);
        protected void TransferCapture(int capnum, int uncapnum, int start, int end);
        protected void Uncapture();
        protected bool IsMatched(int cap);
        protected int MatchIndex(int cap);
        protected int MatchLength(int cap);
    }
}
