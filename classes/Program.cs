using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Kursadi = "C#";
            kurs1.Egitmen = "Asli";
            kurs1.IzlenmeOrani = 60;
            Console.WriteLine(kurs1.Kursadi);

            Kurs[] kurslar = new Kurs[]
                { kurs1};

        }
        class Kurs
        {
            public string Kursadi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }
    }
}
