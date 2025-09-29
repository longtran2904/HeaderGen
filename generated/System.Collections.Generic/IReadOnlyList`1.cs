#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Collections.Generic
{
    [DefaultMember("Item")]
    public interface IReadOnlyList<T> : IEnumerable, IEnumerable<T>, IReadOnlyCollection<T>
    {

        T this[int index] { get; }
    }
}
