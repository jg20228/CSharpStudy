using System;

namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 1;
            //while (true)
            //{
            //    num++;
            //    if (num % 3 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(num);

            //    if (num == 100)
            //    {
            //        break;
            //    }
            //}

            do
            {
                Console.WriteLine(num++);
            } while (num < 10);
        }
    }
}
