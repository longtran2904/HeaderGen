#region DLLTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\Projects\HeaderGen\DLLTest\bin\Debug\net8.0\DLLTest.dll
#endregion

using System.Threading.Tasks;

public struct TestUnsafe
{

    public unsafe fixed int array[16];
    public int* ptr;
    public int*[][] ptrArr;
    public (int a, int b, int*[] c)*[][] tuplePtr;

    public int UnsafeFunc1();
    public int* UnsafeFunc2();
    public int*[] UnsafeFunc3();
    public async void MyFunc1();
    public async Task<int> AsyncFunc(int p);
    public class UnsafeClass
    {

        public int* Ptr;

        public UnsafeClass();
    }
}
