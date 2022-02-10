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
        }
    }
}
