using System;

namespace Семинар1С_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int max = a;
            
            if(b > max)
            {
            max = b;
            }

            if(c > max)
            {
            max = c;
            }
            Console.WriteLine(max);
        }
    }
}
