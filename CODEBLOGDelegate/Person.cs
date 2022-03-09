using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCODEBLOG
{
    class Person
    {
        public event Action GoToSleep;
        //
        public event EventHandler DoWork;

        public string Name { get; set; }
        public void TakeTime(DateTime now)
        {
            if (now.Hour <= 8)
            {
                GoToSleep?.Invoke();
            }
            else
            {
                //var args = new EventArgs();
                //DoWork?.Invoke(this, args); 

                DoWork?.Invoke(this,null); 
                // передаем самого человека, и какие либо параметры
            }
        }
    }
}
