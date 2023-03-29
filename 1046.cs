using System;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor=new string[2];

            int inicio, fim, duracao;

            vetor=Console.ReadLine().Split(' ');
            inicio=int.Parse(vetor[0]);
            fim=int.Parse(vetor[1]);

            if(fim>inicio){
                duracao=fim-inicio;
                Console.WriteLine("O JOGO DUROU "+duracao+" HORA(S)");
            }

            if(inicio==fim){
                duracao=24;
                Console.WriteLine("O JOGO DUROU "+duracao+" HORA(S)");
            }

            if(inicio>fim){
                duracao=Math.Abs(24-(inicio-fim));
                Console.WriteLine("O JOGO DUROU "+duracao+" HORA(S)");
            }
        }
    }
}
