﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
     class Program 
    {

        static void Main(string[] args)
        {
            var point = new Point(10, 20);
            point.Move(new Point (40,60));
            Console.WriteLine("Point is at ({0},{1}, point.x , point.y");
            point.Move(100, 200);
        }
    }
}
