﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 5, '*');
            p1.Draw();
            Point p2 = new Point(5, 15, '$');
            p2.Draw();
            Point p3 = new Point(3, 4, '&');
            p3.Draw();
            Point p4 = new Point(12, 14, '^');
            p4.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }
            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);


            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            
            Console.ReadLine();

        }

    
    }

}
