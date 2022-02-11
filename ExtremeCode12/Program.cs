using System;

namespace ExtremeCode12
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.SayHello();
            Boozer boozer = new Boozer();
            boozer.SayHello();
            boozer.SayBoo();

            //upcast
            Human human1 = boozer;
            //human1.SayBoo();
            //downcast
            Boozer boozer1 = (Boozer)human1;
            boozer1.SayBoo();

            //as is
            Boozer boozer2 = new Boozer();
            Human human2 = boozer2;
            bool boolBoozer = human2 is Boozer;
            if (boolBoozer)
            {
                boozer2 = (Boozer)human2;
            }

            // может быть null
            Boozer boozer3 = new Boozer();
            Human human3 = boozer3;

            boozer3 = human3 as Boozer;
            if (boozer3 != null)
            {
                boozer2.SayBoo();
            }

            //с#7
            Boozer boozer4 = new Boozer();
            Human human4 = boozer4;

            if (human4 is Boozer boozer5)
            {
                boozer5.SayBoo();
            }
        }
    }
}
