using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
            {
                int count = 0;
                for (int i = 2; i <= 88; i += 2)
                {
                    count += i;
                }
                Console.Write(count);
            }
        }
    }


