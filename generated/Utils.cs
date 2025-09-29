#region HeaderGen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\Projects\HeaderGen\bin\Release\net8.0\HeaderGen.dll
#endregion

using System;
using System.Collections.Generic;
using System.Text;

public static class Utils
{
    public const int indent = 4;

    public static StringBuilder AppendIndent(this StringBuilder builder, string str, int indentLevel);
    public static void AppendArray<T>(this StringBuilder builder, IList<T> list, string start, string end, Action<StringBuilder, T> action);
    public static string EscapeString(string str, char ignore);
    public static string Prefix(this string str, string prefix);
    public static IEnumerable<T> Iterate<T>(this T start, Func<T, T> next) where T : class;
    public static void AddRange<T, U>(this IList<T> list, ICollection<U> collection, Func<U, T> convert, Func<U, bool> canProcess = null);
    public static IList<T> AdvanceRange<T>(this IList<T> list, ref int index, int count, bool forward = False);
}
