using System;

namespace dickoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dick dick1 = new Dick(20f, 3f);
            dick1.ShowInfo();
            dick1.Cut(5f);
            dick1.ShowInfo();
            dick1.Brake();
            dick1.ShowInfo();
            DickCreator.Creator();
        }
    }


}
