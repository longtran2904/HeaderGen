#region DLLTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\Projects\HeaderGen\DLLTest\bin\Debug\net8.0\DLLTest.dll
#endregion

namespace DLLTest
{
    public class DLL
    {
        public DLL();

        public class A
        {
            public A();

            public class X
            {
                public X();
            }
        }
        public class A<T>
        {
            public A();

            public class X<U>
            {
                public X();

                public class Y<W>
                {
                    public Y<W> y1;
                    public Y<int> y2;
                    public X<W>.Y<W> y3;
                    public A<float>.X<int>.Y<W> y4;

                    public Y();
                }
            }
        }
        public class B
        {
            public B();

            public class X
            {
                public X x1;
                public A.X x2;
                public X x3;
                public D.X x4;
                public D.E.X x5;

                public X();
            }
        }
        public class C
        {
            public X x1;
            public X.DLL.X x2;
            public DLL dll1;
            public X.DLL dll2;

            public C();
        }
        public class D
        {
            public D();

            public class E
            {
                public X x1;
                public D.X x2;
                public A.X x3;
                public B.X x4;
                public DLL.X x5;

                public E();

                public class X
                {
                    public X();
                }
            }
            public class F
            {
                public X x1;
                public E.X x2;

                public F();
            }
            public class X
            {
                public X();
            }
        }
        public class X
        {
            public X();

            public class DLL
            {
                public X x1;
                public DLLTest.DLL.X x2;
                public D.X x3;
                public D.E.X x4;

                public DLL();

                public class X
                {
                    public DLL dll1;
                    public DLLTest.DLL.X dll2;

                    public X();
                }
            }
        }
    }
}
