using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dickoop
{
    class Bodypart
    {
        private float _health = 100f;

        public virtual void Brake()
        {
            _health = 0;

        }
        public virtual void ShowInfo()
        {
            Console.Write($"Health: {_health}. ");
        }
    }
}
