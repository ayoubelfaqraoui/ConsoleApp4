using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int reste;
            bool flag = true;
            int nbr;

            Console.WriteLine("enter un nombre");
            nbr =Console.Read();
            for (int i = 2; i <= nbr / 2; i++)
            {
                reste = nbr % i;

                if (reste == 0)
                {
                    flag = false;
                    break;
                }
            }
           
            if (flag)
                Console.WriteLine(nbr + " est un nombre premier");
           else
                Console.WriteLine(nbr + " n'est pas un nombre premier");
        }
    }
}
    

