using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiesGetSet
{
    class Point
    {
        private int _x;

        public Point()
        {
            _x = 1;
            Y = 99;
        }

        public int GetX()
        {
            return _x;

        }

        public void  SetX(int x)
        {
            // от 1 до 5
            // организация взаимодействия с полем через инкапсуляцию

            if (x < 1)
            {
                _x = 1;
                return;
            }
            if (x > 5)
            {
                _x = 5;
                return;
            }
            _x = x;

        }

        // свойства get set
        // propfull TAB
        // private int myVar;

        // public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        private int y;

        public int Y
        {
            get { return y; }
            private set {
                if (value < 1)
                {
                    y = 1;
                    return;
                }
                if (value > 10)
                {
                    y = 10;
                    return;
                }
                y = value; }
        }




    }
}
