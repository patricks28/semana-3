using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_3_ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la velocidad de conexión en mbps: ");
            double mbps = Convert.ToDouble(Console.ReadLine());

            double kbps = mbps * 1000;
            double gbps = mbps * 0.001;

            Console.Write("Las velocidades son las siguientes: ");

            Console.Write("Mbps: " + mbps.ToString("F2") ,".  ");

            Console.Write("   Kbps: " + kbps.ToString("F2") ,".  ");

            Console.Write("   Gbps: " + gbps.ToString("F2"),".  ");

            Console.ReadLine();

        }
    }
}
