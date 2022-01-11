using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxInClassObjects
{
    class Cat
    {
        // синтаксис инициализации объектов класса
        public int Age { get; set; }
        public string Name { get; set; }

        public Owner Owner { get; set; }
        public Cat()
        {

        }

        public Cat(string name)
        {
            Name = name;
        }

    }
}
