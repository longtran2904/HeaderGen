#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Globalization
{
    public sealed class NumberFormatInfo : ICloneable, IFormatProvider
    {
        public NumberFormatInfo();

        public static NumberFormatInfo InvariantInfo { get; }
        public int CurrencyDecimalDigits { get; set; }
        public string CurrencyDecimalSeparator { get; set; }
        public bool IsReadOnly { get; }
        public int[] CurrencyGroupSizes { get; set; }
        public int[] NumberGroupSizes { get; set; }
        public int[] PercentGroupSizes { get; set; }
        public string CurrencyGroupSeparator { get; set; }
        public string CurrencySymbol { get; set; }
        public static NumberFormatInfo CurrentInfo { get; }
        public string NaNSymbol { get; set; }
        public int CurrencyNegativePattern { get; set; }
        public int NumberNegativePattern { get; set; }
        public int PercentPositivePattern { get; set; }
        public int PercentNegativePattern { get; set; }
        public string NegativeInfinitySymbol { get; set; }
        public string NegativeSign { get; set; }
        public int NumberDecimalDigits { get; set; }
        public string NumberDecimalSeparator { get; set; }
        public string NumberGroupSeparator { get; set; }
        public int CurrencyPositivePattern { get; set; }
        public string PositiveInfinitySymbol { get; set; }
        public string PositiveSign { get; set; }
        public int PercentDecimalDigits { get; set; }
        public string PercentDecimalSeparator { get; set; }
        public string PercentGroupSeparator { get; set; }
        public string PercentSymbol { get; set; }
        public string PerMilleSymbol { get; set; }
        public string[] NativeDigits { get; set; }
        public DigitShapes DigitSubstitution { get; set; }

        public static NumberFormatInfo GetInstance(IFormatProvider formatProvider);
        public object Clone();
        public object GetFormat(Type formatType);
        public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi);
    }
}
