using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dickoop
{
    class Dick : Bodypart
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
            Console.WriteLine($"Режем: {amount}");
        }

        public override void Brake()
        {
            base.Brake();
            _leftBall.Brake();
            _rightBall.Brake();
            Console.WriteLine("Разбиваем");
        }

        public override void ShowInfo()
        {
            Console.Write("Dick: ");
            base.ShowInfo();
            Console.Write($"L: {_length}, R {_radius} | ");
            _leftBall.ShowInfo();
            _rightBall.ShowInfo();
            Console.WriteLine();
        }
    }
}
