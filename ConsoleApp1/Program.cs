using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double ploshad(Figure[] n)
            {
                double sum = 0;
                for(int i=0;i<n.Length;i++)
                {
                    sum += n[i].Plochad();
                }
                return sum;
            }

            Figure[] a = new Figure[9];
            for(int i=0;i<9;i+=3)
            {
                a[i] = new Triangle(1,2,3);
                a[i + 1] = new Rectangle(1,2);
                a[i + 2] = new Square(1);
            }
            
            Console.WriteLine(ploshad(a));
            Console.ReadKey();
        }
        
    }
}
