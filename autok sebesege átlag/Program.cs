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
            int n, s;
            Console.WriteLine("Hány auto sebbeséget kérjem be?");
            Console.Write(" autók száma : ");
            n = Convert.ToInt32(Console.ReadLine());
            s = 0;
            int[] kocsik = new int[20];
            for (int i = 0; i < n; i++)
            {
                Console.Write("auto sebbesége {0} : ", i + 1);
                kocsik[i] = Convert.ToInt32(Console.ReadLine());
                s = s + kocsik[i];

            }
            Console.WriteLine("a kocsik átlagsebbesége {0} ", s/n);
            Console.ReadLine();
        }
    }
}
