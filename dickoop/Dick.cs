using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dickoop
{
    class Dick
    {
        private float _length;
        private float _radius;
        private Ball _leftBall;
        private Ball _rightBall;

        //private float _radius = 3f;

        public Dick(float length, float radius)
        {
            _length = length;
            _radius = radius;
            //_radius = 3f;

            _leftBall = new Ball(3f, 200f);
            _rightBall = new Ball(5f, 300f);
        }

        public void Cut(float amount)
        {
            _length -= amount;
            if (_length < 0)
            {
                _length = 0;
            }
        }
    }
}
