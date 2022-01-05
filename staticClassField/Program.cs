using System;

namespace staticClassField
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWithStaticField.b = 6;

            ClassWithStaticField newClass1 = new ClassWithStaticField();
            newClass1.a = 5;

            var newClass2 = new ClassWithStaticField();
            newClass2.a = 4;




        }
    }
}
