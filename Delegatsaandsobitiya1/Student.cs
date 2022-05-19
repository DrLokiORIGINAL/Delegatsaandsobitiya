using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegatsaandsobitiya1
{
    public delegate void ShowMessage(string message);
    class Student
    {
        public void Move(int distance, ShowMessage method)
        {
            for(int i =1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                method(string.Format("Идет перемещение... Пройдено киломметров: {0}", i));
            }
        }
    }
}
