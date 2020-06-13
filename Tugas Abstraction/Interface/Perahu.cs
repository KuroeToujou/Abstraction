using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Tugas_Abstraction.AbstractionClass;

namespace Tugas_Abstraction.Interface
{
    public class Perahu : IKendaraan
    {
        public void Bergerak()
        {
            Console.WriteLine("Perahu bergerak dengan cara mengambang diatas air");
            Console.WriteLine("Dengan bantuan mesin perahu");
        }
            
     }
}
