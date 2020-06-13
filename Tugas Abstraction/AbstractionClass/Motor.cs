using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Abstraction.AbstractionClass
{
    public class Motor : Kendaraan
    {
        public override void Bergerak()
        {
            Console.WriteLine("Motor bergerak di atas roda");
            Console.WriteLine("Dengan bantuan mesin 4tak/2tak");
        }
    }
}
