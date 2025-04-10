using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Descarga_de_un_archivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño del archivo en megabytes: ");
            double mb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la velocidad de conexion a Internet en MBPS: ");
            double mbps = Convert.ToDouble(Console.ReadLine());

            double td = mb * 8 / mbps;

            int min = (int)td / 60;
            int sec = (int)td % 60;

            Console.Write($"Tiempo estimado de descarga: " + min);
            Console.Write(" minutos y" + sec);
            Console.Write(" segundos.");
            Console.ReadLine();
        }
    }
}
