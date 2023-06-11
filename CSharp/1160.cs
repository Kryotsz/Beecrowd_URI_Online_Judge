using System;
using System.Globalization;

namespace uri1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int T, PA, PB, somaA, somaB, anos=0;
            double G1, G2, crescimentoA, crescimentoB;

            T=int.Parse(Console.ReadLine());

            for(int t=T;t>0;t--){
                string[] vetor=new string[4];
                vetor=Console.ReadLine().Split(' ');
                PA=int.Parse(vetor[0]);
                PB=int.Parse(vetor[1]);
                G1=double.Parse(vetor[2],CultureInfo.InvariantCulture);
                G2=double.Parse(vetor[3],CultureInfo.InvariantCulture);

                somaA=PA;
                somaB=PB;

                do{
                    crescimentoA=(G1/100)*PA;
                    somaA+=(int)crescimentoA;

                    crescimentoB=(G2/100)*PB;
                    somaB+=(int)crescimentoB;

                    anos+=1;
                    Console.WriteLine(somaA);
                    Console.WriteLine(somaB);
                    if(anos>100){
                        Console.WriteLine("Mais de 1 seculo.");
                        break;
                    }
                }

                while(somaA<=somaB);

                if(anos==100){
                    Console.WriteLine("100 anos.");
                }else{
                    Console.WriteLine(anos+" anos.");
                    break;
                }
            }
        }
    }
}
