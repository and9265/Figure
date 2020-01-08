using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Square:Figure
    {
        private double ar;
        public Square(int a)
        {
            ar = a;
            Console.WriteLine("Square ok");
        }
        
        override public double Perimetr()
        {

            return 4 * ar;
        }
        override public double Plochad() 
        {
            return Math.Pow(ar, 2);
        }
    }
}
