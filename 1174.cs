using System;
using System.Globalization;

namespace uri1174
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor=new double[100];

            for(int i=0;i<100;i++){
                vetor[i]=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(vetor[i]<10||vetor[i]==10){
                    Console.WriteLine("A["+i+"] = "+vetor[i].ToString("F1",CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
