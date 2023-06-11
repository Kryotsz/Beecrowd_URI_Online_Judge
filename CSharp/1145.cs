using System;

namespace uri1145
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, cont=1;

            string[] vetor=new string[2];
            vetor=Console.ReadLine().Split(' ');
            X=int.Parse(vetor[0]);
            Y=int.Parse(vetor[1]);

            for(int i=1;i<=Y;i++){
                if(cont<X){
                    Console.Write(i+" ");
                    cont+=1;
                }else if(cont==X){
                    Console.WriteLine(i);
                    cont=1;
               }
            }   
        }
    }
}
