using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_2_kursporv_del_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parts parts = new Parts(12, 2, 1, 2300, 2800);
            Console.WriteLine(parts.CarPerformance());
        }
    }
}
