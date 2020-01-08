using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Rectangle:Figure
    {
        private double ar;
        private double ar2;
        public Rectangle(int a,int b)
        {
            ar = a;
            ar2 = b;
            Console.WriteLine("Rectangle ok");
        }
        override public double Perimetr()
        {
            return (ar+ar2)*2;
        }
        override public double Plochad()
        {
            return ar*ar2;
        }
    }
}
