using System;
using System.Collections.Generic;

namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //var num = 1;
            //for (; num <= 10; num++)
            //{
            //    Console.WriteLine(num);
            //}

            List<int> numberList = new List<int>();

            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(4);
            numberList.Add(5);

            foreach(var num in numberList)
            {
                Console.WriteLine(num);
            }

            for(var index=1; index<=numberList.Count; index++)
            {
                Console.WriteLine(numberList[index]);
            }
        }
    }
}
