using System;

namespace StructureXY
{
    class Program
    {
        static void Main(string[] args)
        {
            // две реализации Point
            static void Foo(ClassPoint classPoint)
            {
                classPoint.X++;
                classPoint.Y++;
            }
            static void Bar(StructPoint structPoint)
            {
                structPoint.X++;
                structPoint.Y++;
            }

            ClassPoint classPoint = new ClassPoint();
            StructPoint structPoint = new StructPoint();

            // передается ссылка на одни и те же данные в управляемой куче и реальные данные поменяются
            Foo(classPoint);
            // структуры передаются по значению, при выходе из метода поля 0
            // (при передаче структуры поля копируются в новый экземпляр)
            Bar(structPoint);

        }
    }
}
