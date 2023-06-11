using System;
using System.Globalization;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double area = area=3.14159 * Math.Pow(raio, 2);
            Console.WriteLine("A="+area.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
