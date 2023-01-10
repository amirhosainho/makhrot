using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makhrot
{
    internal class Program
    {
        private const double p = 3.14;
        private const double n = 0.33;

        static void Main(string[] args)
        {
            float h, r, v;
            Console.Write(" plase enter h : " );
            h = float.Parse(Console.ReadLine());
            Console.Write(" plase enter r : " );
            r = float.Parse(Console.ReadLine());
            v =(float)(n * p * ((float)Math.Pow(r, 2)) * h);
            Console.WriteLine(" hajm mekhrot = "+v);
            Console.ReadKey();


        }
    }
}
