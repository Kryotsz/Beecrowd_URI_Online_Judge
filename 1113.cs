using System;

namespace uri1113
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            string[] vetor;

            vetor=Console.ReadLine().Split(' ');
            X=int.Parse(vetor[0]);
            Y=int.Parse(vetor[1]);

            // enquanto X for diferente de Y o loop continua
            while(X!=Y){
                // se X é menor que Y a condição é atendida
                if(X<Y){
                    Console.WriteLine("Crescente");
                }else{
                    Console.WriteLine("Decrescente");
                }
                // ler valores novamente enquanto o loop estiver funcionando
                vetor=Console.ReadLine().Split(' ');
                X=int.Parse(vetor[0]);
                Y=int.Parse(vetor[1]);
            }
        }
    }
}
