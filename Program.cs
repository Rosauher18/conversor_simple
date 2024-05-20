using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longitud en metros: ");
            double metro = Convert.ToDouble(Console.ReadLine());

            double pie = metro * 3.28084;

            Console.WriteLine("{0} metros son {1} pies.", metro, pie);
            Console.ReadLine();











        }
    }
}
