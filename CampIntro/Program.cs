using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add5(1,2,4));
            Console.ReadLine();
        }

        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
