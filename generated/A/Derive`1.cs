#region DLLTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\Projects\HeaderGen\DLLTest\bin\Debug\net8.0\DLLTest.dll
#endregion

namespace A
{
    public class Derive<T> : Base<T>.Inner2
    {
        public InnerInner<T> inner;

        public Derive();

        public class Derive2 : Base<float>.Inner
        {
            public Derive2();
        }
    }
}
