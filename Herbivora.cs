using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Herbivora : IHewan
    {
        public void Jenis()
        {
            Console.WriteLine("Hewan pemakan tumbuh tumbuhan.");
            Console.WriteLine("Hewan yang jinak ataupun juga ada yg ganas.");
        }
    }
}