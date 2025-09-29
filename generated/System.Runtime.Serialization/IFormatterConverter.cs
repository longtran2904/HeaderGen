#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Serialization
{
    [CLSCompliant(False)]
    [Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
    public interface IFormatterConverter
    {
        object Convert(object value, Type type);
        object Convert(object value, TypeCode typeCode);
        bool ToBoolean(object value);
        char ToChar(object value);
        sbyte ToSByte(object value);
        byte ToByte(object value);
        short ToInt16(object value);
        ushort ToUInt16(object value);
        int ToInt32(object value);
        uint ToUInt32(object value);
        long ToInt64(object value);
        ulong ToUInt64(object value);
        float ToSingle(object value);
        double ToDouble(object value);
        decimal ToDecimal(object value);
        DateTime ToDateTime(object value);
        string ToString(object value);
    }
}
