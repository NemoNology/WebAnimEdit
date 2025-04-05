namespace WebAnimEdit.Models.Extensions;

public struct RgbaColor(
    byte red = byte.MinValue,
    byte green = byte.MinValue,
    byte blue = byte.MinValue,
    byte alpha = byte.MaxValue) : IConvertible
{
    public byte Red = red;
    public byte Green = green;
    public byte Blue = blue;
    public byte Alpha = alpha;

    private byte MergedByteValue => (byte)(Red | Green | Blue | Alpha);
    private int RgbaIntValue => (int)(Red << 24 | Green << 16 | Blue << 8 | Alpha << 0);

    public TypeCode GetTypeCode()
    {
        return TypeCode.Int32;
    }

    public bool ToBoolean(IFormatProvider? provider)
    {
        return Alpha > 0;
    }

    public byte ToByte(IFormatProvider? provider)
    {
        return MergedByteValue;
    }

    public char ToChar(IFormatProvider? provider)
    {
        return (char)MergedByteValue;
    }

    public DateTime ToDateTime(IFormatProvider? provider)
    {
        return DateTime.FromBinary(RgbaIntValue);
    }

    public decimal ToDecimal(IFormatProvider? provider)
    {
        return RgbaIntValue;
    }

    public double ToDouble(IFormatProvider? provider)
    {
        return RgbaIntValue;
    }

    public short ToInt16(IFormatProvider? provider)
    {
        return (short)MergedByteValue;
    }

    public int ToInt32(IFormatProvider? provider)
    {
        return RgbaIntValue;
    }

    public long ToInt64(IFormatProvider? provider)
    {
        return RgbaIntValue;
    }

    public sbyte ToSByte(IFormatProvider? provider)
    {
        return (sbyte)MergedByteValue;
    }

    public float ToSingle(IFormatProvider? provider)
    {
        return RgbaIntValue;
    }

    public string ToString(IFormatProvider? provider)
    {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        return this.ToString();
    }

    public object ToType(Type conversionType, IFormatProvider? provider)
    {
        return MergedByteValue;
    }

    public ushort ToUInt16(IFormatProvider? provider)
    {
        return (ushort)MergedByteValue;
    }

    public uint ToUInt32(IFormatProvider? provider)
    {
        return (uint)RgbaIntValue;
    }

    public ulong ToUInt64(IFormatProvider? provider)
    {
        return (ulong)RgbaIntValue;
    }

    public override string ToString()
    {
        return $"#{Red}{Green}{Blue}{Alpha}";
    }
}