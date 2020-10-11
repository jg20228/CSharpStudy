using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace CSharpStudy
{
    class User
    {
        // JAVA에서 getter와 setter 사용할때
        //private int id;
        //private string name;

        //public void setId(int id)
        //{
        //    this.id = id;
        //}
        //public int getId()
        //{
        //    return id;
        //}

        //--------------------------
        // C# 3.0이상에서 가능 
        // 번호, 이름, 나이, 연락처

        public int No { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
    }
}
