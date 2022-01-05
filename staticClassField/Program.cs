using System;

namespace staticClassField
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassWithStaticField.b = 6;


            ClassWithStaticField newClass1 = new ClassWithStaticField();
            //newClass1.a = 5;
            newClass1.SetB(11);

            var newClass2 = new ClassWithStaticField();
            //newClass2.a = 4;
            newClass2.PrintB();




        }
    }
}
