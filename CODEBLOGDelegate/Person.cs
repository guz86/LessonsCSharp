﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCODEBLOG
{
    class Person
    {
        public event Action GoToSleep;

        public void TakeTime(DateTime now)
        {
            if (now.Hour <= 8)
            {
                GoToSleep?.Invoke();
            }
        }
    }
}
