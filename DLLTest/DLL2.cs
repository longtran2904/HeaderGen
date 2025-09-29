
public class Test
{
    public A.X a1;
    public DLLTest.DLLNamespace.A a2; // Must write the entire name
    
    public DLLTest.DLLNamespace.Boolean boolean1;
    public DLLTest.DLLNamespace.Char char1;
    public DLLTest.DLLNamespace.SByte sbyte1;
    public DLLTest.DLLNamespace.Byte byte1;
    public DLLTest.DLLNamespace.Int16 short1;
    public DLLTest.DLLNamespace.UInt16 ushort1;
    public DLLTest.DLLNamespace.Int32 int1;
    public DLLTest.DLLNamespace.UInt32 uint1;
    public DLLTest.DLLNamespace.Int64 long1;
    public DLLTest.DLLNamespace.UInt64 ulong1;
    public DLLTest.DLLNamespace.Single float1;
    public DLLTest.DLLNamespace.Double double1;
    public DLLTest.DLLNamespace.Decimal decimal1;
    public DLLTest.DLLNamespace.IntPtr intptr1;
    public DLLTest.DLLNamespace.UIntPtr uintptr1;
    
    public DLLTest.DLLNamespace.Void void1;
    public DLLTest.DLLNamespace.String string1;
    public DLLTest.DLLNamespace.Type type1;
    public DLLTest.DLLNamespace.Exception exception1;
    public DLLTest.DLLNamespace.Attribute attribute1;
    
    public DLLTest.DLLNamespace.Object object1;
    public DLLTest.DLLNamespace.ValueType valuetype1;
    public DLLTest.DLLNamespace.Enum enum1;
    public DLLTest.DLLNamespace.Delegate delegate1;
    public DLLTest.DLLNamespace.MulticastDelegate multicastdelegate1;
    public DLLTest.DLLNamespace.Array array1;
    
    public bool boolean2;
    public char char2;
    public sbyte sbyte2;
    public byte byte2;
    public short short2;
    public ushort ushort2;
    public int int2;
    public uint uint2;
    public long long2;
    public ulong ulong2;
    public float float2;
    public double double2;
    public decimal decimal2;
    public System.IntPtr intptr2;
    public System.UIntPtr uintptr2;
    
    public string string2;
    public System.Type type2;
    public System.Exception exception2;
    public System.Attribute attribute2;
    
    public object object2;
    public struct valuetype2;
    public enum enum2;
    public System.Delegate delegate2;
    public delegate void multicastdelegate2();
    public delegate DLLTest.DLLNamespace.Void multicastdelegate3();
    public System.Array array2;
    
    public Int32 int3;
    
    public class Nested
    {
        public Char c;
    }
    
    public class Char { }
}

public class Int32
{
    
}

public class TupleTest
{
    public (int, float) tuple;
    public (int x1, int x2, int x3, int x4, int x5, int x6, int x7, int, int) tuple0_1;
    public (int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9) tuple0_2;
    public (int x1, int x2, int x3, int x4, int x5, int x6, int x7, (int x8, int x9)) tuple0_3;
    public (int, int, int, int, int, int, int, int x8, int x9) tuple0_4;
    public (int, int, int, int, int, int, int, (int x8, int x9)) tuple0_5;
    public System.ValueTuple<int, int, int, int, int, int, int, (int x8, int x9)> tuple0_6;
    public (int x1, int x2, int x3, int x4, int x5, int x6, int x7, (int, int) x) tuple0_7;
    public (int x1, int x2, int x3, int x4, int x5, int x6, int x7, (int x8, int x9) x) tuple0_8;
    public (int x1, int x2, int x3, int x4, int x5, int x6, int x7, (int x8, int x9, int x0) x) tuple0_9;
    
    public (int a, (float d, ((string h, (bool j, short k) i) f, object g) e) b,
            (double l, ((decimal p, char q) n, ulong o) m) c) tuple1_1;
    public (int a, float b, (string f, bool g) c, (object h, double i) d, (decimal j, char k) e) tuple1_2;
    public (int i, float f, (string, bool) t1, (object obj, double d), (decimal, char c) t2) tuple1_3;
    
    public (int a, float b, bool c, char d, string e, object f, long g, double h) tuple2_1;
    public (int a, float b, bool c, char d, string e, object f, long g, double h, decimal i, byte j) tuple2_2;
    public (bool a, char b, sbyte c, byte d, short e, ushort f, int g, uint h, long i, ulong j, float, double, decimal,
            System.IntPtr, System.UIntPtr) tuple2_3;
    public (bool a, char b, sbyte c, byte d, short e, ushort f, int g, uint h, long i, ulong j, float k, double l, decimal m,
            System.IntPtr n, System.UIntPtr o) tuple2_4;
    public (bool a, char b, sbyte c, byte d, short e, ushort f, int g, uint h, long i, ulong j, float, double, decimal,
            System.IntPtr, System.UIntPtr, string, System.Type, System.Exception, System.Attribute) tuple2_5;
    
    public (int, float flt, bool, char c, string str, object obj, long, double dbl, decimal num, byte[] arr) tuple3_1;
    public (int, float flt, bool, char c, string str, object obj, long, double dbl, decimal num, byte[] arr)[] tuple3_2;
    public (int a, float b, bool c, char d, string e, object f, long g, double h, decimal i, byte[] j, short k)[] tuple3_3;
    
    public (int a1, float a2, bool a3, char a4, string a5, object a6, long a7,
            (int b3, float b4, bool b5, char b6, string b7, object b8, long b9, (double c3, double c4) c1,
             (byte c5, byte c6, (int c8, int c9, int d1, int d2, int d3, int d4, int d5,
                                 (int d7, int d8, int d9) d6) c7) c2) a8, (decimal e1, int e2, float e3) a9,
            (byte e4, int e5, object[] e6)[] b1, ushort b2)[] tuple4_1;
    public List<(System.Collections.IList a, System.Array,
                 (Dictionary<int, (float c, string)>,
                  (byte, int d, List<(bool, (int, (string, (char f, float g))))>[][] e)[] b))> tuple4_2;
    
    public class TupleAttribute : System.Attribute
    {
        public TupleAttribute(params System.Type[] types) { }
    }
    
    [Tuple(typeof((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int, int)),
           typeof((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9)),
           typeof(System.ValueTuple<int, int, int, int, int, int, int, (int x8, int x9)>))]
    public (int a, (int d, ((int h, (int j, int k) i) f, int g) e) b, (int l, ((int p, int q) n, int o) m) c)
        TupleFunc<T, U>((int a, float b, (string f, bool g) c, (object h, double i) d, (decimal j, char k) e) arg1,
                        List<(System.Collections.IList a, System.Array,
                              (Dictionary<int, (float c, string)>,
                               (byte, int d, List<(bool, (int, (T, (char f, U g))))>[][] e)[] b))> arg2)
    {
        return default;
    }
}

public struct TestUnsafe
{
    public unsafe fixed int array[16];
    public unsafe int* ptr;
    public unsafe int*[][] ptrArr;
    public unsafe (int a, int b, int*[] c)*[][] tuplePtr;
    
    public unsafe class UnsafeClass { public int* Ptr; }
    
    public unsafe int  UnsafeFunc1() => 0;
    public unsafe int* UnsafeFunc2() => null;
    public unsafe int*[] UnsafeFunc3() => null;
    
    public async void MyFunc1() { }
    public async unsafe Task<int> AsyncFunc(int p) => 10;
}

public class TestInterface : IEnumerator<TestInterface>, ICloneable
{
    public TestInterface Current => null;
    object System.Collections.IEnumerator.Current => null;
    
    public object Clone() => null;
    public bool MoveNext() => false;
    public void Dispose() { }
    public void Reset() { }
    
    public interface IA { int Do(); }
    public interface IB : IA { }
    public interface IC : IB { }
    
    public class CA : IA
    {
        public int Do() => 1;
    }
    
    public class CB : CA
    {
        public new int Do() => 2;
    }
    
    public class CC : CB, IA
    {
        
    }
    
    public class Outer
    {
        // NOTE(long): If these two were classes instead of interfaces, it would be an error
        private interface Hidden
        {
            public interface InnerPublic { }
        }
        
        public class D1 : Hidden { }
        public class D2 : Hidden.InnerPublic { }
    }
}
