using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ancho_de_banda_s3e1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Ingrese la cantidad en megabytes de los datos a transferir.");
            double dat = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese los segundos el tiempo disponible para la transferencia.");
            double time = Convert.ToDouble(Console.ReadLine());

            double anb = dat * 8 / time;

            Console.WriteLine($"El ancho de banda necesario es: " + anb.ToString("F2") ," MBPS.");
            Console.ReadLine();
        }
    }
}
