﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Menu menu = new Menu();
                menu.MainMenu();
            }                       
        }
    }
}
