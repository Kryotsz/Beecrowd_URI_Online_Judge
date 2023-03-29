using System;
using System.Globalization;

namespace uri1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            string[] vetor=new string[3];

            vetor=Console.ReadLine().Split(' ');
            A=double.Parse(vetor[0],CultureInfo.InvariantCulture);
            B=double.Parse(vetor[1],CultureInfo.InvariantCulture);
            C=double.Parse(vetor[2],CultureInfo.InvariantCulture);

            if(A<B+C&&B<A+C&&C<A+B){
                Console.WriteLine("Perimetro = "+(A+B+C).ToString("F1",CultureInfo.InvariantCulture));
            }else{
                Console.WriteLine("Area = "+(C*(A+B)/2).ToString("F1",CultureInfo.InvariantCulture));
            }



        }
    }
}
