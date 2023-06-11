using System;
using System.Globalization;

namespace uri1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, distancia;

            string[] ponto1=new string[2];
            ponto1=Console.ReadLine().Split(' ');
            x1=double.Parse(ponto1[0],CultureInfo.InvariantCulture);
            y1=double.Parse(ponto1[1],CultureInfo.InvariantCulture);

            string[] ponto2=new string[2];
            ponto2=Console.ReadLine().Split(' ');
            x2=double.Parse(ponto2[0],CultureInfo.InvariantCulture);
            y2=double.Parse(ponto2[1],CultureInfo.InvariantCulture);

            distancia=Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));

            Console.WriteLine(distancia.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
