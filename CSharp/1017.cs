using System;
using System.Globalization;

namespace uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, velmedia;
            double distancia, litros;

            tempo=int.Parse(Console.ReadLine());
            velmedia=int.Parse(Console.ReadLine());

            distancia=velmedia*tempo;
            litros=distancia/12;

            Console.WriteLine(litros.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
