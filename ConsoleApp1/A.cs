using System;

namespace ConsoleApp1
{
    class A : ISome
    {
        public void isomeMethod1()
        {
            Console.WriteLine("I implement ISome");
        }

        public int isomeMethod2()
        {
            return 0;
        }
    }
}
