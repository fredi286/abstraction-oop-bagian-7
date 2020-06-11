using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Omnivora : Hewan
    {
        public override void Jenis()
        {
            Console.WriteLine("Hewan pemakan tumbuh tumbuhan dan daging.");
            Console.WriteLine("Hewan yang sangat buas.");
        }
    }
}