using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converting_ft_to_cm
{
    class Program
    {
        static void Main(string[] args)
        {
            Double ft;
            Double cm;
            Console.Write("input number to be converted from ft to cm");
            ft = Convert.ToDouble(Console.ReadLine());
            cm = ft * 30.48;
            Console.WriteLine("{0}", cm);
            Console.ReadLine();


        }
    }
}
