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


            // Equals

            ClassPoint classPoint1 = new ClassPoint();
            ClassPoint classPoint2 = new ClassPoint();

            // (сравнивает ссылки ) две разные ссылки на разные объекты в куче
            bool classesAreEqual = classPoint1.Equals(classPoint2); // false

            StructPoint structPoint1 = new StructPoint();
            StructPoint structPoint2 = new StructPoint();

            // сравнение идет по значениям полей
            bool structsAreEqual = structPoint1.Equals(structPoint2); // true



        }
    }
}
