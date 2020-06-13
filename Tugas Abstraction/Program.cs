using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tugas_Abstraction.AbstractionClass;


namespace Tugas_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Kendaraan kendaraan;

            kendaraan = new Motor();
            kendaraan.Bergerak();

            Console.WriteLine();
            kendaraan = new Perahu();
            kendaraan.Bergerak();
            
            Console.ReadKey();
        }
    }
}
