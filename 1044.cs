using System;

namespace uri1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor=new string[2];
            int A, B;

            vetor=Console.ReadLine().Split(' ');
            A=int.Parse(vetor[0]);
            B=int.Parse(vetor[1]);

            if(B%A==0||A%B==0){
                Console.WriteLine("Sao Multiplos");
            }else{
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
