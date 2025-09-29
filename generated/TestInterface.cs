#region DLLTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\Projects\HeaderGen\DLLTest\bin\Debug\net8.0\DLLTest.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;

public class TestInterface : ICloneable, IDisposable, IEnumerator, IEnumerator<TestInterface>
{
    public TestInterface();

    public TestInterface Current { get; }

    public object Clone();
    public bool MoveNext();
    public void Dispose();
    public void Reset();

    public interface IA
    {
        int Do();
    }
    public interface IB : IA
    {
    }
    public interface IC : IA, IB
    {
    }
    public class CA : IA
    {
        public CA();

        public int Do();
    }
    public class CB : CA
    {
        public CB();

        public int Do();
    }
    public class CC : CB
    {
        public CC();
    }
    public class Outer
    {
        public Outer();

        public class D1 : Hidden
        {
            public D1();
        }
        public class D2 : Hidden.InnerPublic
        {
            public D2();
        }
    }
}
