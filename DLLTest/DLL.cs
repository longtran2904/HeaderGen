
namespace DLLTest
{
    namespace DLLNamespace
    {
        public class DLL { }
        
        public class A
        {
            public class DLL { }
            
            public DLL dll1;
            public DLLNamespace.DLL dll2;
            public DLLTest.DLL dll3;
            
            public Boolean booleanField;
            public Char charField;
            public SByte sbyteField;
            public Byte byteField;
            public Int16 int16Field;
            public UInt16 uint16Field;
            public Int32 int32Field;
            public UInt32 uint32Field;
            public Int64 int64Field;
            public UInt64 uint64Field;
            public Single singleField;
            public Double doubleField;
            public Decimal decimalField;
            public IntPtr intptrField;
            public UIntPtr uintptrField;
            
            public Void voidField;
            public String stringField;
            public Type typeField;
            public Exception exceptionField;
            public Attribute attributeField;
            
            public Object objectField;
            public ValueType valuetypeField;
            public Enum enumField;
            public Delegate delegateField;
            public MulticastDelegate multicastdelegateField;
            public Array arrayField;
        }
        
        public class Boolean { }
        public class Char { }
        public class SByte { }
        public class Byte { }
        public class Int16 { }
        public class UInt16 { }
        public class Int32 { }
        public class UInt32 { }
        public class Int64 { }
        public class UInt64 { }
        public class Single { }
        public class Double { }
        public class Decimal { }
        public class IntPtr { }
        public class UIntPtr { }
        
        public class Void { }
        public class String { }
        public class Type { }
        public class Exception { }
        public class Attribute { }
        
        public class Object { }
        public class ValueType { }
        public class Enum { }
        public class Delegate { }
        public class MulticastDelegate { }
        public class Array { }
    }
    
    public class DLL
    {
        public class A
        {
            public class X
            {
                
            }
        }
        
        public class A<T>
        {
            public class X<U>
            {
                public class Y<W>
                {
                    public Y<W> y1;
                    public Y<int> y2;
                    public X<W>.Y<W> y3;
                    public A<float>.X<int>.Y<W> y4;
                }
            }
        }
        
        public class B
        {
            public class X
            {
                public X x1;
                public A.X x2;
                public B.X x3;
                public D.X x4;
                public D.E.X x5;
            }
        }
        
        public class C
        {
            public X x1;
            public X.DLL.X x2;
            
            public DLL dll1;
            public X.DLL dll2;
        }
        
        public class D
        {
            public class E
            {
                public X x1;
                public D.X x2;
                public A.X x3;
                public B.X x4;
                public DLL.X x5;
                
                public class X
                {
                    
                }
            }
            
            public class F
            {
                public X x1;
                public E.X x2;
            }
            
            public class X
            {
                
            }
        }
        
        public class X
        {
            public class DLL
            {
                public X x1;
                public DLLTest.DLL.X x2;
                public D.X x3;
                public D.E.X x4;
                
                public class X
                {
                    public DLL dll1;
                    public DLLTest.DLL.X dll2;
                }
            }
        }
    }
}

namespace A
{
    public class X
    {
        public class Int32 { }
    }
    
    public class Int32 { }
    
    namespace B
    {
        public class X
        {
            public int int1;
            public Int32 int2;
            public C.Int32 int3;
            public global::Int32 int4;
            public DLLTest.DLLNamespace.Int32 int5;
            public A.X.Int32 int6;
        }
        
        namespace C
        {
            public class Int32 { }
        }
    }
    
    public class OG
    {
        public class A { }
        public class Inner { }
        public class Inner1 { }
    }
    
    public class Base<T> : OG
    {
        public class A { }
        public class Inner : OG.Inner { }
        public class Inner2 : Inner1
        {
            public class InnerInner<U> { }
        }
    }
    
    public class Derive : Base<int>
    {
        public class Inner  : Base<long>.Inner  { }
        public class Inner3 : Base<char>.Inner2 { }
        public class Inner4 : Inner1 { }
        public class Inner5 : Inner2 { }
    }
    
    public class Derive<T> : Base<T>.Inner2
    {
        public InnerInner<T> inner;
        public class Derive2 : Base<float>.Inner { }
    }
    
    public class Outer : OG
    {
        public class Inner1 : Base<float>
        {
            public A a;
        }
        
        public class Inner2 : Derive
        {
            public A a;
        }
    }
}

public class DLL
{
    public class A
    {
        public class DLL
        {
            public DLL dll1;
            public global::DLL dll2;
            public DLLTest.DLL dll3;
            public DLLTest.DLLNamespace.DLL dll4;
            public DLLTest.DLLNamespace.A.DLL dll5;
            public global::A.X x;
        }
    }
}
