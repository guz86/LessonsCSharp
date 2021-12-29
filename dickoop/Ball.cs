using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dickoop
{
    class Ball : Bodypart
    {
        private float _radius;
        private float _sperm;

        public Ball(float radius, float sperm)
        {
            _radius = radius;
            _sperm = sperm;

        }
        public override void ShowInfo()
        {
            Console.Write("Ball: ");
            base.ShowInfo();
            Console.Write($"R: {_radius}, Q: {_sperm}. | ");
        }
    }
}
