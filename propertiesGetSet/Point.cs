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
        }

        public int GetX()
        {
            return _x;

        }

        public void  SetX(int x)
        {
            // от 1 до 5

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
    }
}
