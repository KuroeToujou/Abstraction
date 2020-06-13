using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Abstraction.AbstractionClass;

namespace Tugas_Abstraction.Interface
{
    public class Motor : IKendaraan
    {
        public void Bergerak()
        {
            Console.WriteLine("Motor bergerak di atas roda");
            Console.WriteLine("Dengan bantuan mesin 4tak/2tak");
        }
    }
}
