using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wprowadzenieDoInf
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string zbior = x < 0 ? "ujemne" : x >= 0 && x <= 9 ? "jednocyfrowe dodatnie" : x >= 10 && x <= 99 ? "dodatnie dwucyfrowe" : "pozostałe";
            Console.WriteLine(zbior);
            Console.ReadKey();
        }
    }
}
