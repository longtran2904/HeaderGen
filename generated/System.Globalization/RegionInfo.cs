#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Globalization
{
    public class RegionInfo
    {

        public RegionInfo(string name);
        public RegionInfo(int culture);

        public static RegionInfo CurrentRegion { get; }
        public virtual string Name { get; }
        public virtual string EnglishName { get; }
        public virtual string DisplayName { get; }
        public virtual string NativeName { get; }
        public virtual string TwoLetterISORegionName { get; }
        public virtual string ThreeLetterISORegionName { get; }
        public virtual string ThreeLetterWindowsRegionName { get; }
        public virtual bool IsMetric { get; }
        public virtual int GeoId { get; }
        public virtual string CurrencyEnglishName { get; }
        public virtual string CurrencyNativeName { get; }
        public virtual string CurrencySymbol { get; }
        public virtual string ISOCurrencySymbol { get; }

        public override bool Equals(object value);
        public override int GetHashCode();
        public override string ToString();
    }
}
