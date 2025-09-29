#region DLLTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\Projects\HeaderGen\DLLTest\bin\Debug\net8.0\DLLTest.dll
#endregion

namespace A
{
    public class Derive : Base<int>
    {

        public Derive();
        public class Inner : Base<long>.Inner
        {

            public Inner();
        }
        public class Inner3 : Base<char>.Inner2
        {

            public Inner3();
        }
        public class Inner4 : Inner1
        {

            public Inner4();
        }
        public class Inner5 : Inner2
        {

            public Inner5();
        }
    }
}
