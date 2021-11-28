using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hraci_Kostka_Objekty
{
    class Program
    {
        static void Main()
        {
            Kostka sestistenna = new Kostka(); // v tuto chvíli se zavolá konstruktor
            Kostka desetistenna = new Kostka(10); // v tuto chvíli se zavolá konstruktor
            Console.WriteLine(desetistenna.VratPocetSten());
            Console.WriteLine(sestistenna.hod());
            Console.WriteLine(sestistenna);
            Console.ReadKey();
        }
    }
}