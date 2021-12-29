using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dickoop
{
    static class DickCreator
    {
        static public void Creator()
        {
            Dick dick;
            for (int i = 0; i < 10; i++)
            {
                dick = new Dick(20f, 3f);
                dick.ShowInfo();
            }
        }
    }
}
