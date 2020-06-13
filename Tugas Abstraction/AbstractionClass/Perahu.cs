using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Abstraction.AbstractionClass
{
    public class Perahu : Kendaraan
    {
        public override void Bergerak()
        {
            Console.WriteLine("Perahu bergerak dengan cara mengambang diatas air");
            Console.WriteLine("Dengan bantuan mesin perahu");
        }
    }
}
