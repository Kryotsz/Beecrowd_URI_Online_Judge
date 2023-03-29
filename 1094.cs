using System;
using System.Globalization;

namespace uri1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, quantia, totalcobaias=0, totalcoelhos=0, totalratos=0, totalsapos=0;
            char tipo=' ';
            double percentualcoelho, percentualrato, percentualsapo;

            N=int.Parse(Console.ReadLine());

            for(int i=1;i<=N;i++){
                string[] vetor=new string[2];
                vetor=Console.ReadLine().Split(' ');
                quantia=int.Parse(vetor[0]);
                tipo=char.Parse(vetor[1]);

                totalcobaias+=quantia;

                if(tipo=='C'){
                    totalcoelhos+=quantia;
                }

                if(tipo=='R'){
                    totalratos+=quantia;
                }

                if(tipo=='S'){
                    totalsapos+=quantia;
                }
            }
            percentualcoelho=(double)(totalcoelhos*100.00)/totalcobaias;
            percentualrato=(double)(totalratos*100.00)/totalcobaias;
            percentualsapo=(double)(totalsapos*100.00)/totalcobaias;

            Console.WriteLine("Total: "+totalcobaias+" cobaias");
            Console.WriteLine("Total de coelhos: "+totalcoelhos);
            Console.WriteLine("Total de ratos: "+totalratos);
            Console.WriteLine("Total de sapos: "+totalsapos);
            Console.WriteLine("Percentual de coelhos: "+percentualcoelho.ToString("F2",CultureInfo.InvariantCulture)+" %");
            Console.WriteLine("Percentual de ratos: "+percentualrato.ToString("F2",CultureInfo.InvariantCulture)+" %");
            Console.WriteLine("Percentual de sapos: "+percentualsapo.ToString("F2",CultureInfo.InvariantCulture)+" %");
        }
    }
}
