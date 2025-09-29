#region DLLTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\Projects\HeaderGen\DLLTest\bin\Debug\net8.0\DLLTest.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;

public class TupleTest
{
    public (int, float) tuple;
    public (int x1, int x2, int x3, int x4, int x5, int x6, int x7, int, int) tuple0_1;
    public (int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9) tuple0_2;
    public (int x1, int x2, int x3, int x4, int x5, int x6, int x7, (int x8, int x9)) tuple0_3;
    public (int, int, int, int, int, int, int, int x8, int x9) tuple0_4;
    public (int, int, int, int, int, int, int, (int x8, int x9)) tuple0_5;
    public (int, int, int, int, int, int, int, int, int) tuple0_6;
    public (int x1, int x2, int x3, int x4, int x5, int x6, int x7, (int, int) x) tuple0_7;
    public (int x1, int x2, int x3, int x4, int x5, int x6, int x7, (int x8, int x9) x) tuple0_8;
    public (int x1, int x2, int x3, int x4, int x5, int x6, int x7, (int x8, int x9, int x0) x) tuple0_9;
    public (int a, (float d, ((string h, (bool j, short k) i) f, object g) e) b, (double l, ((decimal p, char q) n, ulong o) m) c) tuple1_1;
    public (int a, float b, (string f, bool g) c, (object h, double i) d, (decimal j, char k) e) tuple1_2;
    public (int i, float f, (string, bool) t1, (object obj, double d), (decimal, char c) t2) tuple1_3;
    public (int a, float b, bool c, char d, string e, object f, long g, double h) tuple2_1;
    public (int a, float b, bool c, char d, string e, object f, long g, double h, decimal i, byte j) tuple2_2;
    public (bool a, char b, sbyte c, byte d, short e, ushort f, int g, uint h, long i, ulong j, float, double, decimal, nint, nuint) tuple2_3;
    public (bool a, char b, sbyte c, byte d, short e, ushort f, int g, uint h, long i, ulong j, float k, double l, decimal m, nint n, nuint o) tuple2_4;
    public (bool a, char b, sbyte c, byte d, short e, ushort f, int g, uint h, long i, ulong j, float, double, decimal, nint, nuint, string, Type, Exception, Attribute) tuple2_5;
    public (int, float flt, bool, char c, string str, object obj, long, double dbl, decimal num, byte[] arr) tuple3_1;
    public (int, float flt, bool, char c, string str, object obj, long, double dbl, decimal num, byte[] arr)[] tuple3_2;
    public (int a, float b, bool c, char d, string e, object f, long g, double h, decimal i, byte[] j, short k)[] tuple3_3;
    public (int a1, float a2, bool a3, char a4, string a5, object a6, long a7, (int b3, float b4, bool b5, char b6, string b7, object b8, long b9, (double c3, double c4) c1, (byte c5, byte c6, (int c8, int c9, int d1, int d2, int d3, int d4, int d5, (int d7, int d8, int d9) d6) c7) c2) a8, (decimal e1, int e2, float e3) a9, (byte e4, int e5, object[] e6)[] b1, ushort b2)[] tuple4_1;
    public List<(IList a, Array, (Dictionary<int, (float c, string)>, (byte, int d, List<(bool, (int, (string, (char f, float g))))>[][] e)[] b))> tuple4_2;

    public TupleTest();

    [Tuple(new[] {typeof((int, int, int, int, int, int, int, int, int)), typeof((int, int, int, int, int, int, int, int, int)), typeof((int, int, int, int, int, int, int, int, int)) })]
    public (int a, (int d, ((int h, (int j, int k) i) f, int g) e) b, (int l, ((int p, int q) n, int o) m) c) TupleFunc<T, U>((int a, float b, (string f, bool g) c, (object h, double i) d, (decimal j, char k) e) arg1, List<(IList a, Array, (Dictionary<int, (float c, string)>, (byte, int d, List<(bool, (int, (T, (char f, U g))))>[][] e)[] b))> arg2);

    public class TupleAttribute : Attribute
    {
        public TupleAttribute(params Type[] types);
    }
}
