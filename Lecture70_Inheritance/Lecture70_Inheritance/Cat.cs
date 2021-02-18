using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture70_Inheritance
{
    class Cat : Animal //ใช้ทุกอย่างใน super class ใน class ลูกได้
    {
        string name;

        public string Name { get => name; set => name = value; }

        public string cry()
        {
            return "Meaowwwwwwwww";
        }
    }
}
