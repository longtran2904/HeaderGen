#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    [CLSCompliant(False)]
    public interface IConvertible
    {

        TypeCode GetTypeCode();
        bool ToBoolean(IFormatProvider provider);
        char ToChar(IFormatProvider provider);
        sbyte ToSByte(IFormatProvider provider);
        byte ToByte(IFormatProvider provider);
        short ToInt16(IFormatProvider provider);
        ushort ToUInt16(IFormatProvider provider);
        int ToInt32(IFormatProvider provider);
        uint ToUInt32(IFormatProvider provider);
        long ToInt64(IFormatProvider provider);
        ulong ToUInt64(IFormatProvider provider);
        float ToSingle(IFormatProvider provider);
        double ToDouble(IFormatProvider provider);
        decimal ToDecimal(IFormatProvider provider);
        DateTime ToDateTime(IFormatProvider provider);
        string ToString(IFormatProvider provider);
        object ToType(Type conversionType, IFormatProvider provider);
    }
}
