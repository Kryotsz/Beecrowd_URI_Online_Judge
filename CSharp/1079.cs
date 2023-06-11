using System;
using System.Globalization;

namespace uri1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double A, B, C, media;

            N=int.Parse(Console.ReadLine());
            
            string[] vetor1=new string[3];

            for (int i=1; i<=N; i++){
                 vetor1=Console.ReadLine().Split(' ');
            A=double.Parse(vetor1[0],CultureInfo.InvariantCulture);
            B=double.Parse(vetor1[1],CultureInfo.InvariantCulture);
            C=double.Parse(vetor1[2],CultureInfo.InvariantCulture);
            media=(A*2+B*3+C*5)/10;
            Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
            }
        }
    }
}
