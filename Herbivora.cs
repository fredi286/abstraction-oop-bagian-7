using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Herbivora : Hewan
    {
        public override void Jenis()
        {
            Console.WriteLine("Hewan pemakan tumbuh tumbuhan.");
            Console.WriteLine("Hewan yang jinak ataupun juga ada yg ganas.");
        }
    }
}