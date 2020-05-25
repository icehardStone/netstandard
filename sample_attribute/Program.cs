using System;

namespace sample_attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            // QueryAttribute
            Test_QueryAttribute test1 = new Test_QueryAttribute();
            test1.Test();

            Test_Person test2 = new Test_Person();
            test2.Test();
        }
    }
}
