using System;
using System.Globalization;

namespace uri1178
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal X;

            decimal[] vetor=new decimal[100];

            X=decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            vetor[0]=X;
            Console.WriteLine("N[0] = "+vetor[0].ToString("F4",CultureInfo.InvariantCulture));

            for(int i=1;i<=99;i++){
                vetor[i]=vetor[i-1]/2;
                Console.WriteLine("N["+i+"] = "+vetor[i].ToString("F4",CultureInfo.InvariantCulture));
            }
        }
    }
}
