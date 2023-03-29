using System;

namespace uri1115
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            string[] vetor=new string[2];

            vetor=Console.ReadLine().Split(' ');
            X=int.Parse(vetor[0]);
            Y=int.Parse(vetor[1]);

            while(X!=0&&Y!=0){
                if(X>0&&Y>0){
                    Console.WriteLine("primeiro");
                }

                if(X<0&&Y>0){
                    Console.WriteLine("segundo");
                }

                if(X<0&&Y<0){
                    Console.WriteLine("terceiro");
                }

                if(X>0&&Y<0){
                    Console.WriteLine("quarto");
                }

                vetor=Console.ReadLine().Split(' ');
                X=int.Parse(vetor[0]);
                Y=int.Parse(vetor[1]);

            }
        }
    }
}
