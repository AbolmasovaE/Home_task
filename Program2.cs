using System;

namespace Task_1
{
    class Program
    {
        public static int Main()
        {
            for (int i = 0; i <= 40; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
            return 0;
        }
    }
}
    