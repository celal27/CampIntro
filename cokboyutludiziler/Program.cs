using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cokboyutludiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] regions = new string[5,3]
            {
            {"İstanbul","Aydin","Denizli1"},
            {"İstanbul","Aydin","Denizli2"},
            {"İstanbul","Aydin","Denizli3"},
            {"İstanbul","Aydin","Denizli4"},
            {"İstanbul","Aydin","Denizli5"}

                };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                    if (j == 2) 
                    {
                        Console.WriteLine("-----------------");
                    }  
                }
            }
            Console.ReadLine();
        }
    }
}
