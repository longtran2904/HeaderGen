#region DLLTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\Projects\HeaderGen\DLLTest\bin\Debug\net8.0\DLLTest.dll
#endregion

namespace A
{
    public class Base<T> : OG
    {

        public Base();
        public class A
        {

            public A();
        }
        public class Inner : OG.Inner
        {

            public Inner();
        }
        public class Inner2 : Inner1
        {

            public Inner2();
            public class InnerInner<U>
            {

                public InnerInner();
            }
        }
    }
}
