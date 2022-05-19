﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegatsaandsobitiya2
{
    public class Student
    {
        public void Move(int distance, Action<string> method)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                method(string.Format("Идет перемещение... Пройдено киломметров: {0}", i));
            }
        }
    }
}
