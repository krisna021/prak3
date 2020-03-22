using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.NamaDriver = "krisna";
            taxi.OnDuty = true;
            taxi.JumlahPenumpang = 10;

            taxi.InfoTaxi();
            taxi.JemputPenumpang();
            taxi.AntarPenumpang();

            Console.ReadKey();
        }
    }
} 