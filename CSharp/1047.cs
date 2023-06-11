using System;

namespace uri1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor=new string[4];
            int horai, horaf, mini, minf, horas, minutos;

            vetor=Console.ReadLine().Split(' ');
            horai=int.Parse(vetor[0]);
            mini=int.Parse(vetor[1]);
            horaf=int.Parse(vetor[2]);
            minf=int.Parse(vetor[3]);

            horas=horaf-horai;
            
            if(horas<0){
                horas+=24;
            }

            minutos=minf-mini;

            if(minutos<0){
                minutos+=60;
                horas-=1;
                if(horas<0){
                    horas+=24;
                }
            }

            if(minutos==0&&horas==0){
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }else{
                Console.WriteLine("O JOGO DUROU "+horas+" HORA(S) E "+minutos+" MINUTO(S)");
            }
        }
    }
}
