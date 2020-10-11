using System;
using System.Collections.Generic;

namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 2 3 4 5 6 7 8 9 10

            // var num = 1;

            // Generic List 
            //새로운 메모리에 적재될 공간이 마련되어야해서 new를 함
            //List<string> list = new List<string>();
            //list.Add("text1");
            //list.Add("text2");
            //list.Add("text3");
            //list.Add("text4");
            //list.Add("text5");

            //foreach (var text in list)
            //{
            //    Console.WriteLine(text);
            //}

            //유지보수할때 뒤에 제네릭만 수정하면 되어서 편함
            //var list = new List<int>();
            //list.Add(1);



            var list = new List<string>()
            {
                "text1",
                "text2",
                "text3",
                "text4",
                "text5"
            };

            foreach(var text in list)
            {
                Console.WriteLine(text);
            }

            //-------------------------------------
            //1 2 3 4 5 6 7 8 9 10 x
            //1 2 3 4 5 6 7 8 9 10 y
            //2차원 배열로 표현하는게 DB

            //ex
            //번호  이름     나이 연락처
            // 01   임꺽정   20  010-0000-0000
            // 02   홍길동   20  010-0000-0000

            var user1 = new User()
            {
                No = 1,
                Name = "임꺽정",
                Age = 30,
                Phone = "010-0000-0000"
            };

            var user2 = new User()
            {
                No=2,
                Name="홍길동",
                Age = 30,
                Phone = "010-0000-0000"
            };

            var userList = new List<User>()
            {
                user1,user2
            };

            foreach(var user in userList)
            {
                Console.WriteLine("번호 : " + user.No);
                Console.WriteLine("이름 : " + user.Name);
            }
        }
    }
}
