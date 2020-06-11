using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.AbstractClass;    // Menggunakan Abstract Class
//using Abstraction.Interface;      // Menggunakan Interface

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Hewan hewan;          // Menggunakan Abstract Class
            hewan = new Herbivora();
            hewan.Jenis();

            Console.WriteLine();
            hewan = new Karnivora();
            hewan.Jenis();

            Console.WriteLine();
            hewan = new Omnivora();
            hewan.Jenis();


            /*IHewan hewan;       // Menggunakan Abstract Class
            hewan = new Herbivora();
            hewan.Jenis();
            Console.WriteLine();
            hewan = new Karnivora();
            hewan.Jenis();
            Console.WriteLine();
            hewan = Omnivora();
            hewan.Jenis()*/

            Console.ReadKey();
        }
    }
}