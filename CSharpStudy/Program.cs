using System;

namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = 1;
            var num2 = 2;

            Console.WriteLine(num1 + num2);


            //변수 선언시 타입은 소문자로 한다.
            //숫자
            short shortNum = 0;
            
            int intNum = 0;
            
            double doubleNum = 0;
            
            float floatNum = 0; //부동소수점

            //문자 
            //C#에서는 String은 string이다.
            //이유 : C++에서 파생된것이라서
            string stringText = "";

            char charText = 'a';

            //boolean -> bool
            bool flag = true;



            //doNet 변수선언

            Int16 dotNetShort = 0;

            Int32 dotNetInt = 0;

            Int64 dotNetDouble = 0;

            String dotNetString = "";

            // 다이나믹 타입
            //C# 컴파일러가 알아서 타입을 해줌
            var dynamicType = 0;

            var testNum = 1;

            //자바스크립트는 가능함 testNum = "2";

        }
    }
}
