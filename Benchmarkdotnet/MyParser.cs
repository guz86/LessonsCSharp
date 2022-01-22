﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarkdotnet
{
    class MyParser
    {
        public int TryCathParse(string str)
        {
            int result;
            try
            {
                result = int.Parse(str);
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
    }


}
