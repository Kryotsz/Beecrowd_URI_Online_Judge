using System;

namespace uri1061
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dia1=new string[2];
            string[] duraçao1;
            string[] dia2=new string[2];
            string[] duraçao2;
            int diai, horai, mini, segi, diaf, horaf, minf, segf, totali, totalf, tempo;

            dia1=Console.ReadLine().Split(' ');
            diai=int.Parse(dia1[1]);

            duraçao1=Console.ReadLine().Split(' ');
            horai=int.Parse(duraçao1[0]);
            mini=int.Parse(duraçao1[2]);
            segi=int.Parse(duraçao1[4]);

            // SEPARAÇÃO DO PRIMEIRO DIA PRO ULTIMO-----------------------------------------------------------------------------------------------------

            dia2=Console.ReadLine().Split(' ');
            diaf=int.Parse(dia2[1]);

            duraçao2=Console.ReadLine().Split(' ');
            horaf=int.Parse(duraçao2[0]);
            minf=int.Parse(duraçao2[2]);
            segf=int.Parse(duraçao2[4]);

            totali=segi+mini*60+horai*3600+diai*86400;
            totalf=segf+minf*60+horaf*3600+diaf*86400;

            tempo=totalf-totali;

            Console.WriteLine((tempo/86400)+" dia(s)",tempo=tempo%86400);
            Console.WriteLine((tempo/3600)+" hora(s)",tempo=tempo%3600);
            Console.WriteLine((tempo/60)+" minuto(s)",tempo=tempo%60);
            Console.WriteLine(tempo+" segundo(s)");

        }
    }
}
