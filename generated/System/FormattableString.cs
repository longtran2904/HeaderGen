#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public abstract class FormattableString : IFormattable
    {

        protected FormattableString();

        public abstract string Format { get; }
        public abstract int ArgumentCount { get; }

        public abstract object[] GetArguments();
        public abstract object GetArgument(int index);
        public abstract string ToString(IFormatProvider formatProvider);
        public static string Invariant(FormattableString formattable);
        public static string CurrentCulture(FormattableString formattable);
        public override string ToString();
    }
}
