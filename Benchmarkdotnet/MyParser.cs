using System;
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
            //int result;
            //try
            //{
            //    result = int.Parse(str);
            //}
            //catch (Exception)
            //{
            //    result = 0;
            //}
            //return result;
            try
            {
                return int.Parse(str);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int TryParse(string str)
        {
            int result;
            if (!int.TryParse(str, out result))
            {
                result = 0;
            }

            return result;
        }
    }


}
