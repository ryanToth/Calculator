﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (!MainMenu.Instance.Exit)
            {
                MainMenu.Instance.Print();
            }
        }
    }
}
