#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace System
{
    public abstract class StringComparer : IComparer, IComparer<string>, IEqualityComparer, IEqualityComparer<string>
    {

        protected StringComparer();

        public static StringComparer InvariantCulture { get; }
        public static StringComparer InvariantCultureIgnoreCase { get; }
        public static StringComparer CurrentCulture { get; }
        public static StringComparer CurrentCultureIgnoreCase { get; }
        public static StringComparer Ordinal { get; }
        public static StringComparer OrdinalIgnoreCase { get; }

        public static StringComparer FromComparison(StringComparison comparisonType);
        public static StringComparer Create(CultureInfo culture, bool ignoreCase);
        public static StringComparer Create(CultureInfo culture, CompareOptions options);
        public static bool IsWellKnownOrdinalComparer(IEqualityComparer<string> comparer, out bool ignoreCase);
        public static bool IsWellKnownCultureAwareComparer(IEqualityComparer<string> comparer, out CompareInfo compareInfo, out CompareOptions compareOptions);
        public int Compare(object x, object y);
        public bool Equals(object x, object y);
        public int GetHashCode(object obj);
        public abstract int Compare(string x, string y);
        public abstract bool Equals(string x, string y);
        public abstract int GetHashCode(string obj);
    }
}
