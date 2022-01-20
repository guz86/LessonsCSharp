using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class B : A
    {
        public B()
        {
            Console.WriteLine(publicField);
            //Console.WriteLine(privateField);// доступ имеет сам класс где он прописан
            Console.WriteLine(protectedField);
            Foo();
        }
    }
}
