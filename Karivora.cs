using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Karnivora : Hewan
    {
        public override void Jenis()
        {
            Console.WriteLine("Hewan pemakan daging.");
            Console.WriteLine("hewan yang ganas dan mempunyai gigi yang keras.");
        }
    }
}