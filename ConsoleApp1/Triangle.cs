using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public  class Triangle:Figure
    {
        private double ar;
        private double ar2;
        private double ar3;
       public Triangle(double a,double b,double c)
        {
            ar = a;
            ar2 = b;
            ar3 = c;
            Console.WriteLine("Triangle ok");
        }
        override public double Perimetr()
        {
            
            return ar+ar2+ar3;
        }
        override public double Plochad()
        {
            double p = Perimetr() / 2;
            return Math.Sqrt(p*(p-ar)*(p-ar2)*(p-ar3));
        }
    }
}
