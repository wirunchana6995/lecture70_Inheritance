using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture70_Inheritance
{
    class Animal // พิมพ์เขียว -> super class
    {
        int sizeOfAnimal = 0; //ถ้าต้องการให้ get, set ได้ ต้องทำ refactor -> encapsulate

        public int SizeOfAnimal { get => sizeOfAnimal; set => sizeOfAnimal = value; } //edit->refactor->encapsulate field

        public string breat() //behavior
        {
            return "I am OK";
        }
        private string move()
        {
            return "Go Go Go !!!";
        }
    }

}
