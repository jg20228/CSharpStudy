using System;

namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 1;
            Console.Write("0~9사이의 값을 입력 : ");

            var input = Console.ReadLine();

            //string과 integer의 같음을 비교 할수 없음
            if (input == num.ToString())
            {
                Console.WriteLine("값 같음");

            }
            else
            {
                Console.WriteLine("값 틀림");
            }

            // Java 에서 
            if (input == num.ToString()){
                Console.WriteLine("값 같음");
            }else{
                Console.WriteLine("값 틀림");
            }
        }
    }
}
