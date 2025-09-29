#region DLLTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\Projects\HeaderGen\DLLTest\bin\Debug\net8.0\DLLTest.dll
#endregion

namespace A
{
    public class Outer : OG
    {

        public Outer();
        public class Inner1 : Base<float>
        {

            public A a;

            public Inner1();
        }
        public class Inner2 : Derive
        {

            public A a;

            public Inner2();
        }
    }
}
